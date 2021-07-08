using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using UnityEditor;
using UnityEngine;

namespace CGTK.Utilities.BetterMath.Editor
{
    [CustomPropertyDrawer(type: typeof(Boolx2x2)), CustomPropertyDrawer(type: typeof(Boolx2x3)), CustomPropertyDrawer(type: typeof(Boolx2x4))]
    [CustomPropertyDrawer(type: typeof(Boolx3x2)), CustomPropertyDrawer(type: typeof(Boolx3x3)), CustomPropertyDrawer(type: typeof(Boolx3x4))]
    [CustomPropertyDrawer(type: typeof(Boolx4x2)), CustomPropertyDrawer(type: typeof(Boolx4x3)), CustomPropertyDrawer(type: typeof(Boolx4x4))]

    [CustomPropertyDrawer(type: typeof(F32x2x2)), CustomPropertyDrawer(type: typeof(F32x2x3)), CustomPropertyDrawer(type: typeof(F32x2x4))]
    [CustomPropertyDrawer(type: typeof(F32x3x2)), CustomPropertyDrawer(type: typeof(F32x3x3)), CustomPropertyDrawer(type: typeof(F32x3x4))]
    [CustomPropertyDrawer(type: typeof(F32x4x2)), CustomPropertyDrawer(type: typeof(F32x4x3)), CustomPropertyDrawer(type: typeof(F32x4x4))]

    [CustomPropertyDrawer(type: typeof(F64x2x2)), CustomPropertyDrawer(type: typeof(F64x2x3)), CustomPropertyDrawer(type: typeof(F64x2x4))]
    [CustomPropertyDrawer(type: typeof(F64x3x2)), CustomPropertyDrawer(type: typeof(F64x3x3)), CustomPropertyDrawer(type: typeof(F64x3x4))]
    [CustomPropertyDrawer(type: typeof(F64x4x2)), CustomPropertyDrawer(type: typeof(F64x4x3)), CustomPropertyDrawer(type: typeof(F64x4x4))]

    [CustomPropertyDrawer(type: typeof(I32x2x2)), CustomPropertyDrawer(type: typeof(I32x2x3)), CustomPropertyDrawer(type: typeof(I32x2x4))]
    [CustomPropertyDrawer(type: typeof(I32x3x2)), CustomPropertyDrawer(type: typeof(I32x3x3)), CustomPropertyDrawer(type: typeof(I32x3x4))]
    [CustomPropertyDrawer(type: typeof(I32x4x2)), CustomPropertyDrawer(type: typeof(I32x4x3)), CustomPropertyDrawer(type: typeof(I32x4x4))]

    [CustomPropertyDrawer(type: typeof(U32x2x2)), CustomPropertyDrawer(type: typeof(U32x2x3)), CustomPropertyDrawer(type: typeof(U32x2x4))]
    [CustomPropertyDrawer(type: typeof(U32x3x2)), CustomPropertyDrawer(type: typeof(U32x3x3)), CustomPropertyDrawer(type: typeof(U32x3x4))]
    [CustomPropertyDrawer(type: typeof(U32x4x2)), CustomPropertyDrawer(type: typeof(U32x4x3)), CustomPropertyDrawer(type: typeof(U32x4x4))]
    internal class MatrixDrawer : PropertyDrawer
    {
        public override Boolean CanCacheInspectorGUI(SerializedProperty property)
        {
            return false;
        }

        public override Single GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (!property.isExpanded)
                return EditorGUIUtility.singleLineHeight;
            Int32 __rows = 1 + property.type[property.type.Length - 3] - '0';
            return __rows * EditorGUIUtility.singleLineHeight + (__rows - 1) * EditorGUIUtility.standardVerticalSpacing;
        }

        static readonly ReadOnlyCollection<String> KColPropertyPaths =
            new ReadOnlyCollection<String>(list: new[] { "c0", "c1", "c2", "c3" });
        static readonly ReadOnlyCollection<String> KRowPropertyPaths =
            new ReadOnlyCollection<String>(list: new[] { "x", "y", "z", "w" });

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(position, property, label, false);

            if (Event.current.type == EventType.ContextClick && position.Contains(Event.current.mousePosition))
            {
                DoUtilityMenu(property);
                Event.current.Use();
            }

            if (!property.isExpanded)
                return;

            Int32 __rows = property.type[property.type.Length - 3] - '0';
            Int32 __cols = property.type[property.type.Length - 1] - '0';

            ++EditorGUI.indentLevel;
            position = EditorGUI.IndentedRect(position);
            --EditorGUI.indentLevel;

            var __elementType = property.FindPropertyRelative(relativePropertyPath: "c0.x").propertyType;
            for (var __row = 0; __row < __rows; ++__row)
            {
                position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
                var __elementRect = new Rect(position)
                {
                    width = __elementType == SerializedPropertyType.Boolean
                        ? EditorGUIUtility.singleLineHeight
                        : (position.width - (__cols - 1) * EditorGUIUtility.standardVerticalSpacing) / __cols
                };
                for (var __col = 0; __col < __cols; ++__col)
                {
                    EditorGUI.PropertyField(
                        __elementRect,
                        property: property.FindPropertyRelative(relativePropertyPath: $"{KColPropertyPaths[__col]}.{KRowPropertyPaths[__row]}"),
                        GUIContent.none
                    );
                    __elementRect.x += __elementRect.width + EditorGUIUtility.standardVerticalSpacing;
                }
            }
        }

        readonly Dictionary<SerializedPropertyType, Action<SerializedProperty, Boolean>> _kUtilityValueSetters =
            new Dictionary<SerializedPropertyType, Action<SerializedProperty, Boolean>>
            {
                { SerializedPropertyType.Boolean, (property, b) => property.boolValue = b },
                { SerializedPropertyType.Float, (property, b) => property.floatValue = b ? 1f : 0f },
                { SerializedPropertyType.Integer, (property, b) => property.intValue = b ? 1 : 0 }
            };

        private void DoUtilityMenu(SerializedProperty property)
        {
            var __rows = property.type[index: property.type.Length - 3] - '0';
            var __cols = property.type[index: property.type.Length - 1] - '0';
            var __elementType = property.FindPropertyRelative(relativePropertyPath: "c0.x").propertyType;
            var __setValue = _kUtilityValueSetters[__elementType];
            var __menu = new GenericMenu();
            property = property.Copy();
            __menu.AddItem(
                content: EditorGUIUtility.TrTextContent(text: "Set to Zero"),
                false,
                () =>
                {
                    property.serializedObject.Update();;
                    for (var __row = 0; __row < __rows; ++__row)
                    for (var __col = 0; __col < __cols; ++__col)
                        __setValue(
                            arg1: property.FindPropertyRelative(relativePropertyPath: $"{KColPropertyPaths[__col]}.{KRowPropertyPaths[__row]}"),
                            false
                        );
                    property.serializedObject.ApplyModifiedProperties();
                }
            );
            if (__rows == __cols)
            {
                __menu.AddItem(
                    content: EditorGUIUtility.TrTextContent(text: "Reset to Identity"),
                    false,
                    () =>
                    {
                        property.serializedObject.Update();
                        for (var __row = 0; __row < __rows; ++__row)
                        for (var __col = 0; __col < __cols; ++__col)
                            __setValue(
                                arg1: property.FindPropertyRelative(relativePropertyPath: $"{KColPropertyPaths[__col]}.{KRowPropertyPaths[__row]}"),
                                arg2: __row == __col
                            );
                        property.serializedObject.ApplyModifiedProperties();
                    }
                );
            }
            __menu.ShowAsContext();
        }
    }
}

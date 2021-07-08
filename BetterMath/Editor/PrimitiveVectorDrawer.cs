using System;
using UnityEditor;
using UnityEngine;

namespace CGTK.Utilities.BetterMath.Editor
{
    [CustomPropertyDrawer(type: typeof(Boolx2)), CustomPropertyDrawer(type: typeof(Boolx3)), CustomPropertyDrawer(type: typeof(Boolx4))]

    //[CustomPropertyDrawer(typeof(F16x2)), CustomPropertyDrawer(typeof(F16x3)), CustomPropertyDrawer(typeof(F16x4))]
    [CustomPropertyDrawer(type: typeof(F32x2)), CustomPropertyDrawer(type: typeof(F32x3)), CustomPropertyDrawer(type: typeof(F32x4))]
    [CustomPropertyDrawer(type: typeof(F64x2)), CustomPropertyDrawer(type: typeof(F64x3)), CustomPropertyDrawer(type: typeof(F64x4))]


    [CustomPropertyDrawer(type: typeof(I32x2)), CustomPropertyDrawer(type: typeof(I32x3)), CustomPropertyDrawer(type: typeof(I32x4))]
    [CustomPropertyDrawer(type: typeof(U32x2)), CustomPropertyDrawer(type: typeof(U32x3)), CustomPropertyDrawer(type: typeof(U32x4))]

    [CustomPropertyDrawer(type: typeof(DoNotNormalizeAttribute))]
    internal class PrimitiveVectorDrawer : PropertyDrawer
    {
        private String _propertyType;

        private String GetPropertyType(SerializedProperty property)
        {
            if (_propertyType != null) return _propertyType;

            _propertyType = property.type;
            Boolean __isManagedRef = property.type.StartsWith(value: "managedReference", StringComparison.Ordinal);

            if (!__isManagedRef) return _propertyType;

            Int32 __startIndex = "managedReference<".Length;
            Int32 __length = _propertyType.Length - __startIndex - 1;
            _propertyType = _propertyType.Substring("managedReference<".Length, __length);

            return _propertyType;
        }

        static class Content
        {
            public static readonly String DoNotNormalizeCompatibility = L10n.Tr(
                str: $"{nameof(DoNotNormalizeAttribute)} only works with {typeof(Quaternion)} and primitive vector types."
            );
            public static readonly String DoNotNormalizeTooltip =
                L10n.Tr(str: "This value is not normalized, which may produce unexpected results.");

            public static readonly GUIContent[] Labels2 = { new GUIContent(text: "X"), new GUIContent(text: "Y") };
            public static readonly GUIContent[] Labels3 = { new GUIContent(text: "X"), new GUIContent(text: "Y"), new GUIContent(text: "Z") };
            public static readonly GUIContent[] Labels4 = { new GUIContent(text: "X"), new GUIContent(text: "Y"), new GUIContent(text: "Z"), new GUIContent(text: "W") };
        }

        public override Boolean CanCacheInspectorGUI(SerializedProperty property)
        {
            return false;
        }

        public override Single GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            Single __height = EditorGUIUtility.singleLineHeight;
            if (!EditorGUIUtility.wideMode)
                __height += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            return __height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUIContent[] __subLabels = Content.Labels4;
            String __startIter = "x";
            String __propertyType = GetPropertyType(property);
            //switch (propertyType[index: propertyType.Length - 1])
            switch (__propertyType[property.type.Length - 1])
            {
                case '2':
                    __subLabels = Content.Labels2;
                    break;
                case '3':
                    __subLabels = Content.Labels3;
                    break;
                case '4':
                    __subLabels = Content.Labels4;
                    break;
                default:
                {
                    if (property.type == nameof(Quaternion))
                        __startIter = "value.x";
                    else if (attribute is DoNotNormalizeAttribute)
                    {
                        EditorGUI.HelpBox(position: EditorGUI.PrefixLabel(position, label), Content.DoNotNormalizeCompatibility, MessageType.None);
                        return;
                    }
                    break;
                }
            }

            if (attribute is DoNotNormalizeAttribute && string.IsNullOrEmpty(label.tooltip))
                label.tooltip = Content.DoNotNormalizeTooltip;

            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.MultiPropertyField(position, __subLabels, valuesIterator: property.FindPropertyRelative(__startIter), label);
            EditorGUI.EndProperty();
        }
    }
}

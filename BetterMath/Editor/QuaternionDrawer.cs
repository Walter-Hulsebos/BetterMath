using UnityEditor;

namespace CGTK.Utilities.BetterMath.Editor
{
    [CustomPropertyDrawer(typeof(Quaternion))]
    internal class QuaternionDrawer : PostNormalizedVectorDrawer
    {
        protected override SerializedProperty GetVectorProperty(SerializedProperty property)
        {
            return property.FindPropertyRelative(relativePropertyPath: "value");
        }

        protected override F64x4 Normalize(F64x4 value)
        {
            return value;
            //return Maths.NormalizeSafe(new Quaternion(value: (F32x4)value)).value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }
        public Vector4(float a, float b, float c, float d)
        {
            x = a;
            y = b;
            z = c;
            w = d;
        }
        public static Vector4 operator+(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
            lhs.x + rhs.x,
            lhs.y + rhs.y,
            lhs.z + rhs.z,
            lhs.w + rhs.w);
        }
        public static Vector4 operator-(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
            lhs.x - rhs.x,
            lhs.y - rhs.y,
            lhs.z - rhs.z,
            lhs.w - rhs.w);
        }
        public static Vector4 operator*(Vector4 lhs, float rhs)
        {
            return new Vector4(
            lhs.x * rhs,
            lhs.y * rhs,
            lhs.z * rhs,
            lhs.w * rhs);
        }
        public static Vector4 operator*(float lhs, Vector4 rhs)
        {
            return new Vector4(
            lhs * rhs.x,
            lhs * rhs.y,
            lhs * rhs.z,
            lhs * rhs.w);
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt((double)(x * x + y * y + z * z + w * w));
        }

        public void Normalize()
        {
            float m = Magnitude();

            x /= m;
            y /= m;
            z /= m;
            w /= m;
        }

        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }

        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x,
                0);
        }

        public static Vector4 operator*(Matrix4 lhs, Vector4 rhs)
        {
            return new Vector4((lhs.m1 * rhs.x) + (lhs.m2 * rhs.y) + (lhs.m3 * rhs.z) + (lhs.m4 * rhs.w),
                               (lhs.m5 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m7 * rhs.z) + (lhs.m8 * rhs.w),
                               (lhs.m9 * rhs.x) + (lhs.m10 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m12 * rhs.w),
                               (lhs.m13 * rhs.x) + (lhs.m14 * rhs.y) + (lhs.m15 * rhs.z) + (lhs.m16 * rhs.w));
        }
    }
}

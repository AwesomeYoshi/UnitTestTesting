using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float m1, m5, m9, m13, m2, m6, m10, m14, m3, m7, m11, m15, m4, m8, m12, m16;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = 1; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = 1;
        }
        public Matrix4(float Xx, float Xy, float Xz, float Xw, float Yx, float Yy, float Yz, float Yw, float Zx, float Zy, float Zz, float Zw, float Wx, float Wy, float Wz, float Ww)
        {
            m1 = Xx; m2 = Yx; m3 = Zx; m4 = Wx;
            m5 = Xy; m6 = Yy; m7 = Zy; m8 = Wy;
            m9 = Xz; m10 = Yz; m11 = Zz; m12 = Wz;
            m13 = Xw; m14 = Yw; m15 = Zw; m16 = Ww;
        }
        public void Set(Matrix4 input)
        {
            m1 = input.m1;
            m5 = input.m5;
            m9 = input.m9;
            m13 = input.m13;
            m2 = input.m2;
            m6 = input.m6;
            m10 = input.m10;
            m14 = input.m14;
            m3 = input.m3;
            m7 = input.m7;
            m11 = input.m11;
            m15 = input.m15;
            m4 = input.m4;
            m8 = input.m8;
            m12 = input.m12;
            m16 = input.m16;

        }
        public void SetRotateX(double radians)
        {
            Matrix4 rx = new Matrix4(1, 0, 0,0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians),0,
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians),0,
                0,0,0,1);

            Set(rx);
        }
        public void SetRotateY(double radians)
        {
            Matrix4 ry = new Matrix4((float)Math.Cos(radians), 0, (float)-Math.Sin(radians), 0,
                                      0, 1, 0, 0,
                                     (float)Math.Sin(radians), 0, (float)Math.Cos(radians),0,
                                     0, 0, 0, 1);

            Set(ry);
        }
        public void SetRotateZ(double radians)
        {
            Matrix4 rz = new Matrix4((float)Math.Cos(radians), (float)Math.Sin(radians), 0, 0,
                                     (float)-Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                                     0, 0, 1, 0,
                                     0, 0, 0, 1);

            Set(rz);
        }
        public static Matrix4 operator*(Matrix4 lhs, Matrix4 rhs)
        {
            return new Matrix4(
                lhs.m1 * rhs.m1 + lhs.m2 * rhs.m5 + lhs.m3 * rhs.m9 + lhs.m4 * rhs.m13,
                lhs.m1 * rhs.m2 + lhs.m2 * rhs.m6 + lhs.m3 * rhs.m10 + lhs.m4 * rhs.m14,
                lhs.m1 * rhs.m3 + lhs.m2 * rhs.m7 + lhs.m3 * rhs.m11 + lhs.m4 * rhs.m15,
                lhs.m1 * rhs.m4 + lhs.m2 * rhs.m8 + lhs.m3 * rhs.m12 + lhs.m4 * rhs.m16,
                lhs.m5 * rhs.m1 + lhs.m6 * rhs.m5 + lhs.m7 * rhs.m9 + lhs.m8 * rhs.m13,
                lhs.m5 * rhs.m2 + lhs.m6 * rhs.m6 + lhs.m7 * rhs.m10 + lhs.m8 * rhs.m14,
                lhs.m5 * rhs.m3 + lhs.m6 * rhs.m7 + lhs.m7 * rhs.m11 + lhs.m8 * rhs.m15,
                lhs.m5 * rhs.m4 + lhs.m6 * rhs.m8 + lhs.m7 * rhs.m12 + lhs.m8 * rhs.m16,
                lhs.m9 * rhs.m1 + lhs.m10 * rhs.m5 + lhs.m11 * rhs.m9 + lhs.m12 * rhs.m13,
                lhs.m9 * rhs.m2 + lhs.m10 * rhs.m6 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m14,
                lhs.m9 * rhs.m3 + lhs.m10 * rhs.m7 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m15,
                lhs.m9 * rhs.m4 + lhs.m10 * rhs.m8 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m16,
                lhs.m13 * rhs.m1 + lhs.m14 * rhs.m5 + lhs.m15 * rhs.m9 + lhs.m16 * rhs.m13,
                lhs.m13 * rhs.m2 + lhs.m14 * rhs.m6 + lhs.m15 * rhs.m10 + lhs.m16 * rhs.m14,
                lhs.m13 * rhs.m3 + lhs.m14 * rhs.m7 + lhs.m15 * rhs.m11 + lhs.m16 * rhs.m15,
                lhs.m13 * rhs.m4 + lhs.m14 * rhs.m8 + lhs.m15 * rhs.m12 + lhs.m16 * rhs.m16);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace jp.hateblo.neoria.Utility
{
    public static class SmoothAxisCalculator
    {
        public static Vector2 GridableToCirclable(float hAxis, float vAxis)
        {
            return GridableToCirclable(new Vector2(hAxis, vAxis));
        }

        /// グリッド状の座標を円上の座標に変換
        public static Vector2 GridableToCirclable(Vector2 vector2)
        {
            // NaN回避
            if (vector2 == Vector2.zero)
            {
                return Vector2.zero;
            }
            Vector2 dir = vector2.normalized;
            float mag = CirclableMagnitude(vector2);
            return dir * mag;
        }

        static float CirclableMagnitude(Vector2 vector2)
        {
            float sqrMagOnSquare = NormalizeOnUnitSquareAndAbs(vector2).sqrMagnitude;
            return vector2.sqrMagnitude / sqrMagOnSquare;
        }

        /// 単位正方形上に正規化
        /// ただし、マグニチュードが算出できればいいため、x,y共に正の値
        static Vector2 NormalizeOnUnitSquareAndAbs(Vector2 dir)
        {
            float slope = dir.y / dir.x;

            if (Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
            {
                return new Vector2(1f, slope);
            }
            return new Vector2(1f / slope, 1f);
        }
    }
}

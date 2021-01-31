using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUnity.SimpleExample
{
    /// <summary>
    /// 方向の定義（XYZ軸ベース)
    /// </summary>
    public enum SpeedDirection
    {
        x,
        y,
        z
    };

    /// <summary>
    /// Vector3の拡張メソッド
    /// </summary>
    public static class Vector3Extension
    {
        /// <summary>
        /// キーボードでRigidbodyコンポーネントの速度を制御するための拡張メソッド
        /// </summary>
        /// <param name="originSpeed">呼び出し元のVector3</param>
        /// <param name="keyCode">操作対象のキー</param>
        /// <param name="speedDirection">動かす方向</param>
        /// <param name="speedPower">動かす力</param>
        /// <returns>キーボード操作によるスピード</returns>
        /// <remarks>
        /// XYZ軸対応なので、キャラクターが向いている方向などと速度を関連付けて制御できない
        /// </remarks>
        public static Vector3 ControlSpeedByKey(this Vector3 originSpeed,KeyCode keyCode,SpeedDirection speedDirection,float speedPower)
        {
            var resultSpeed = originSpeed;

            if(Input.GetKey(keyCode))
            {
                switch(speedDirection)
                {
                    case SpeedDirection.x:
                        resultSpeed.x = speedPower;
                        break;
                    case SpeedDirection.y:
                        resultSpeed.y = speedPower;
                        break;
                    case SpeedDirection.z:
                        resultSpeed.z = speedPower;
                        break;
                    default:
                        break;
                }
            }
            else if(Input.GetKeyUp(keyCode))
            {
                switch (speedDirection)
                {
                    case SpeedDirection.x:
                        resultSpeed.x = 0;
                        break;
                    case SpeedDirection.y:
                        resultSpeed.y = 0;
                        break;
                    case SpeedDirection.z:
                        resultSpeed.z = 0;
                        break;
                    default:
                        break;
                }

            }

            return resultSpeed;
        }
    }
}
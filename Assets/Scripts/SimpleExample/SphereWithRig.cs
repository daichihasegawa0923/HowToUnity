using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUnity.SimpleExample
{
    public class SphereWithRig : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        /// <summary>
        /// Update関数が呼ばれる前に1度だけ呼び出される
        /// </summary>
        void Start()
        {
            // このスクリプトがアタッチされているオブジェクトのコンポーネントから
            // Rigidbodyコンポーネントを取得する
            _rigidbody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// 毎フレーム呼び出される
        /// </summary>
        void Update()
        {
            _rigidbody.velocity = _rigidbody.velocity
                .ControlSpeedByKey(KeyCode.D, SpeedDirection.x, 1)
                .ControlSpeedByKey(KeyCode.A, SpeedDirection.x, -1)
                .ControlSpeedByKey(KeyCode.W, SpeedDirection.z, 1)
                .ControlSpeedByKey(KeyCode.S, SpeedDirection.z, -1);
        }
    }
}
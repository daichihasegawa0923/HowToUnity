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
            var moveDirection = _rigidbody.velocity;

            if (Input.GetKey(KeyCode.D))
            {
                moveDirection.x = 1;
            }
            else if(Input.GetKeyUp(KeyCode.D))
            {
                moveDirection.x = 0;
            }
            
            if(Input.GetKey(KeyCode.A))
            {
                moveDirection.x = -1;
            }
            else if(Input.GetKeyUp(KeyCode.A))
            {
                moveDirection.x = 0;
            }

            if(Input.GetKey(KeyCode.W))
            {
                moveDirection.z = 1;
            }
            else if(Input.GetKeyUp(KeyCode.W))
            {
                moveDirection.z = 1;
            }

            if(Input.GetKey(KeyCode.S))
            {
                moveDirection.z = -1;
            }
            else if(Input.GetKeyUp(KeyCode.S))
            {
                moveDirection.z = 0;
            }

            _rigidbody.velocity = moveDirection;
        }
    }
}
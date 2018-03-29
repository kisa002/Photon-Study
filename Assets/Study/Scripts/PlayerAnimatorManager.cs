using UnityEngine;
using System.Collections;

namespace Com.MyCompany.MyGame
{
    public class PlayerAnimatorManager : MonoBehaviour
    {
        #region MONOBEHAVIOUR MESSAGES

        private Animator animator;

        private bool isJump = false;

        // Use this for initialization
        void Start()
        {
            animator = GetComponent<Animator>();

            if (!animator)
            {
                Debug.LogError("PlayerAnimatorManager is Missing Animator Component", this);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (!animator)
            {
                return;
            }

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            //if (v < 0)
            //{
            //    v = 0;
            //}

            transform.Translate(Vector3.right * h * Time.deltaTime * 4);
            transform.Translate(Vector3.forward * v * Time.deltaTime * 4);
            
            //animator.SetFloat("Speed", h * h + v * v);

            if(Input.GetKeyDown(KeyCode.Space) && !isJump)
            {
                //isJump = true;
                GetComponent<Rigidbody>().velocity = Vector3.up * 5f;
            }
        }

        #endregion
    }
}
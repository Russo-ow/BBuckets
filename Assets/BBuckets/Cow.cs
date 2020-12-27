using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BBuckets {
    public class Cow : MonoBehaviour {
        public float speed;
        Rigidbody2D rb;

        void Start() {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update() {
            rb.velocity = Vector2.right * Input.GetAxis("Horizontal") * speed;
        }
    }
}
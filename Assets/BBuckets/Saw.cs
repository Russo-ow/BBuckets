using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BBuckets {
    public class Saw : MonoBehaviour {
        Rigidbody2D rb;
        public float gravity;

        void Start() {
            rb = GetComponent<Rigidbody2D>();
            rb.gravityScale = 0;
        }

        void Update() {
            if (Input.GetButtonDown("Space")) {
                rb.gravityScale = gravity;
            }
        }

        private void OnTriggerEnter2D(Collider2D other) {
            GameObject cow = other.gameObject;
            BBuckets.instance.Lose();
            Debug.Log("....");
        }
    }
}

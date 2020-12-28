using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BBuckets {
    public class Saw : MonoBehaviour {
        Rigidbody2D rb;
        public float gravity;
        float speed = 0;

        void Start() {
            rb = GetComponent<Rigidbody2D>();
            rb.gravityScale = 0;
            StartCoroutine(SawRevving());
        }

        void Update() {
            if (Input.GetButtonDown("Space")) {
                rb.gravityScale = gravity;
            }
            transform.Rotate(Vector3.forward * speed);
        }

        private void OnTriggerEnter2D(Collider2D other) {
            GameObject cow = other.gameObject;
            BBuckets.instance.Lose();
        }

        IEnumerator SawRevving() {
            float timer = 0;
            yield return new WaitForSeconds(.5f);
            while(speed<=110) {
                timer += Time.deltaTime;
                speed = 27.5f * (timer * timer);
                yield return new WaitForEndOfFrame();
            }
            speed = 110;
        }
    }
}

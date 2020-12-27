using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BBuckets {
    public class BBuckets : MonoBehaviour {

        private void Start() {
            MinigameManager.Instance.minigame.gameWin = true;
            StartCoroutine(SawsSound());
        }

        private void Update() {
            if(Input.GetButtonDown("Space")) {
                if(!MinigameManager.Instance.minigame.gameWin) {
                    MinigameManager.Instance.minigame.gameWin = true;
                    MinigameManager.Instance.PlaySound("moo");
                }
            }
        }

        IEnumerator SawsSound() {
            yield return new WaitForSeconds(.5f);
            MinigameManager.Instance.PlaySound("saws");
        }
    }
}

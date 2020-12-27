using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BBuckets {
    public class BBuckets : MonoBehaviour {
        public Text UIText;
        public string startText;
        public string winText;

        private void Start() {
            UIText.text = startText;
            MinigameManager.Instance.minigame.gameWin = false;
        }

        private void Update() {
            if(Input.GetButtonDown("Space")) {
                if(!MinigameManager.Instance.minigame.gameWin) {
                    MinigameManager.Instance.minigame.gameWin = true;
                    UIText.text = winText;
                    MinigameManager.Instance.PlaySound("win");
                }
            }
        }
    }
}

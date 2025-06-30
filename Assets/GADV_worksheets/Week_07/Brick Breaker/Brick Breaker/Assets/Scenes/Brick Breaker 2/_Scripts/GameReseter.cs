using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class GameReseter : MonoBehaviour  {
        private int scenes = 0;
        //public void RandomizeScene()
        //{
        //    scenes = RandomNumberGenerator(0, 1);
        //}
        public void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.CompareTag("Ball")) return;
            SceneManager.LoadScene(scenes);
        }
    }
}

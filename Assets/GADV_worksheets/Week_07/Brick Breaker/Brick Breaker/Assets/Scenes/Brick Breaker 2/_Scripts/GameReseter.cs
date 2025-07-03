using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class GameReseter : MonoBehaviour  {
        
       
        public void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.CompareTag("Ball")) return;
            int sceneIndex = Random.Range(0, 2);
            Debug.Log($"{sceneIndex}");
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

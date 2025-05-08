using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GADVDataTypes
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0";
        void Start()
        {
            float scaler = float.Parse(scale);
            spriteTransform = GetComponent<Transform>();

            spriteTransform.localScale = new Vector3(scaler, scaler, 1f);
        }



        // Update is called once per frame
        void Update()
        {

        }
    }
}
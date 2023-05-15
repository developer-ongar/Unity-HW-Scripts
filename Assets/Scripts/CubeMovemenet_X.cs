using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ongar
{
    public class CubeMovemenet_X : MonoBehaviour
    {
        public float speed = 2f;
        private float moveDistance = 2f; // Расстояние движения влево и вправо
        private bool isMovingLeft = true; // Флаг направления движения

        private void Update()
        {
            float moveAmount = isMovingLeft ? -moveDistance : moveDistance;
            Vector3 movement = new Vector3(moveAmount, 0f, 0f) * speed * Time.deltaTime;
            transform.Translate(movement);

            if (Mathf.Abs(transform.position.x) >= moveDistance)
            {
                isMovingLeft = !isMovingLeft; // Изменение направления движения
            }
        }
    }
}



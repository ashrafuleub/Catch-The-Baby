using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BostLifeMan : MonoBehaviour
{

    private float speed = 4f;

    private void Update()
    {
        LifeImageDown();
    }

    void LifeImageDown()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);


        if (transform.position.y < -4.19)
        {
            float randomX = Random.Range(-7.25f, 9.15f);
            transform.position = new Vector3(randomX, 5.95f, 0f);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RepetingBaby : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
   

    private void Update()
    {
        DownBaby();
        
    }

    public void DownBaby()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);


        if (transform.position.y < -4.19)
        {
            FindObjectOfType<Movement>().Life();
            float randomX = Random.Range(-7.25f, 9.15f);
            transform.position = new Vector3(randomX, 5.95f, 0f);
        }
    }

   
}

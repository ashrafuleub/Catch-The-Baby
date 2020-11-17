using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatedBaby : MonoBehaviour
{
    public GameObject babyprefeb;
    public GameObject lifeImageDown;
    
    public int babynumber;
    public int lifeDistance;


    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BabyRepeting(babynumber)); 
        StartCoroutine(LifeImageRepete(lifeDistance));


    }
    IEnumerator BabyRepeting(int value)
    {
        while (true)
        {
            yield return new WaitForSeconds(value);
           Instantiate(babyprefeb, new Vector3(Random.Range(-7.25f, 9.15f), 5.95f, 0f), Quaternion.identity);
        }
    }

    IEnumerator LifeImageRepete(int lifevalue)
    {
        while (true)
        {
            yield return new WaitForSeconds(lifevalue);
           Instantiate(lifeImageDown, new Vector3(Random.Range(-7.25f, 9.15f), 5.95f, 0f), Quaternion.identity);
        }
    }

}

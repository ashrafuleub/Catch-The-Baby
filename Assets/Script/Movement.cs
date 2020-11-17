using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    float xInput;
    public float touchSpeed;
    SpriteRenderer sp;

    public int score;
    public Text currentScore;
    int life = 3;
    int lifeValue;
   

    public AudioSource babySound;

    public HealthBar healthbar;

   

    private void Start()
    {
        lifeValue = life;
        healthbar.SetMaxHealth(life);
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-7.40f,8.32f),
                             transform.position.y,transform.position.z);
        
        FlipPlayed();

        currentScore.text = score.ToString();
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal"); // Input left and Right button
        transform.Translate(xInput * moveSpeed, 0f, 0f);
        TouchInput();
    }

   void FlipPlayed()
    {

        if (xInput < -0.1 )
        {
            sp.flipX = true; //Flip the Left Side
        }
        else if(xInput > 0.1)
        {
            sp.flipX = false; //Flip the Right Side
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player") //baby collision of the player then move the script
        {
            babySound.Play(); //if collision of the player then sound
            Destroy(collision.gameObject);
            score += 10; // if collision of the player then add score
        }

        if(collision.gameObject.tag == "life")
        {
            Destroy(collision.gameObject); //if the collision of life image then increse the life
           LifeBost();


        }

        if (score > PlayerPrefs.GetInt("final"))
        {
            PlayerPrefs.SetInt("final", score);//Total Score
        }
    }

    void TouchInput()  //Work is Touch for Mobile 
    {
        Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            
            if (touchPos.x > 1)
            {
                transform.Translate(touchSpeed, 0, 0);//move the player right side
            }

            if (touchPos.x < -1)
            {
                transform.Translate(-touchSpeed, 0, 0); //move the player left side
            }
        }
    }
    public void Life()
    {
        lifeValue--;      // Decrease the Life
        healthbar.setHealth(lifeValue);
        
        if (lifeValue == 0)
        {
            Restart();
        }
        
    }

    public void LifeBost()
    {
        if (lifeValue < 3)
        {
            lifeValue++; // increase the life
            healthbar.setHealth(lifeValue);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(2);
    }

    
}

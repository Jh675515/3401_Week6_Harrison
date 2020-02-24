using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapforce;
    public GameObject gameoverUI;
    int score = 0;
    public AudioSource Jump;
    public AudioSource Coin;
    public AudioSource Pain;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Flappy");
            //birdRigidBody.AddForce(Vector2.up * flapforce);
            birdRigidBody.velocity = Vector2.up * flapforce;
            Jump.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreTag")
        {
            score += 1;
            Debug.Log(score);
            Coin.Play();
        }
        else
        {
            gameoverUI.SetActive(true);
            Time.timeScale = 0;
            Pain.Play();
        }

    }

    public void OnRestartButtonPressed ()
    {
        SceneManager.LoadScene("Harrison_Scene");
        Time.timeScale = 1;
    }
}



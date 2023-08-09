using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndManager : MonoBehaviour
{
    //GameObject.GetComponent<Renderer>().material.color.a = 0.5f;
    //private GameController scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        //scoreManager = GameObject.Find("GameController").GetComponent<GameController>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Add to score when the player hits a cube
            //GameController.score++;
            // Destroy the cube
            //Destroy(gameObject);

            //ignore above comments
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.tag == "Character")
        {
            // Add to score when the player hits a cube
            //GameController.npcScore--;
            // Destroy the cube
            //Destroy(gameObject);

            //ignore above comments
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

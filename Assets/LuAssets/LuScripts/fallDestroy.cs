using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{

    // This is the number that determines at what height the object is destroyed
    public int deathY = -10;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < deathY)
        {

            // Check the current, and grab its name

            Scene scene = SceneManager.GetActiveScene();

            Debug.Log("I DIEEEEEED!");
            Destroy(gameObject);

            // Grab the scene manager and make it load a scene (the current one)
            SceneManager.LoadScene(scene.name);



        }
    }
}

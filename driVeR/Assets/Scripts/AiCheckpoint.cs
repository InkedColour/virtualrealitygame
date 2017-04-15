using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AiCheckpoint : MonoBehaviour {

    int aiLaps;
    float timer = 11.0f;

	// Use this for initialization
	void Start () {
        aiLaps = 0;
    }
	
    void OnTriggerEnter (Collider col)
    {

        if (col.gameObject.tag == "AICheckpoint" && timer >= 10.0f)
        {
            aiLaps++;
            timer = 0.0f; //resets timer so it wount increase laps multiple times a second
        }
    }

	// Update is called once per frame
	void Update () {

        timer = timer + Time.deltaTime;

        if (aiLaps > 3)
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            Debug.Log("You Lose");
        }
        /*else
        {
            Debug.Log("aiLaps = " + aiLaps);
        }*/

	}
}

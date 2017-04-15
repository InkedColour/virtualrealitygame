using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GetReady : MonoBehaviour {

    float timer = 1.0f;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer == 0.0f)
        {
            SceneManager.LoadScene("race_track_lake", LoadSceneMode.Single);
        }
	}
}

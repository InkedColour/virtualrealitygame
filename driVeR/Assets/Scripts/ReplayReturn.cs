using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReplayReturn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("pauseButton"))
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

        if (Input.GetButtonDown("Jump"))
            SceneManager.LoadScene("race_track_lake", LoadSceneMode.Single);

    }
}

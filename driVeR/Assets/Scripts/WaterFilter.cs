using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WaterFilter : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= -5)
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}

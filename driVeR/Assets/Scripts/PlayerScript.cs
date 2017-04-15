using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public float lapNum;
	public float checkpointNum;
	public Text checkpointText;
	public Text lapText;

    // Use this for initialization
    void Start () {

        lapNum = 1;
		checkpointNum = 0;
		checkpointText.text = "Checkpoints: 0/6";
		lapText.text = "Laps: 0/3";
	}

	// Update is called once per frame
	void Update () {
		lapText.text = "Laps: "+lapNum+"/3";

		if (checkpointNum == 6) {
			checkpointNum = 0;
			lapNum++;
		}

        if (lapNum > 3)
        {
            SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
        }
	}
}
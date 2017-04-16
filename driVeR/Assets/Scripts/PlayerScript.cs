using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public float lapNum;
	public float checkpointNum;
	public Text checkpointText;
	public Text lapText;
    public float timer = 25.0f;

    // Use this for initialization
    void Start () {

        lapNum = 0;
		checkpointNum = 0;
		checkpointText.text = "Checkpoints: 0/6";
		lapText.text = "Laps: 0/3";
	}
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "CheckpointReset" && timer >= 20.0f)
        {
            checkpointNum = 0;
            lapNum++;
            timer = 0.0f; //resets timer so it wount increase laps multiple times a second
        }
    }

    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
		lapText.text = "Laps: "+lapNum+"/3";

		/*if (checkpointNum == 6) {
			checkpointNum = 0;
			//lapNum++;
		}*/

        if (lapNum > 3)
        {
            SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
        }
	}
}
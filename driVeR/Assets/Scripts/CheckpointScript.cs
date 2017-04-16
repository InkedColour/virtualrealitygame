using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckpointScript : MonoBehaviour {

	public PlayerScript pScript;
	public float pCheckpointNum;
	public Text checkpointText;

	public bool hasPassed;

    float pointTimer;

	// Use this for initialization
	void Start () {
		pScript = FindObjectOfType<PlayerScript>();
		pCheckpointNum = pScript.checkpointNum;

		hasPassed = false;

        pointTimer = 5.0f;

		//checkpointText.text = "Checkpoints: 0";
	}

	// Update is called once per frame
	void Update () {
		//checkpointText.text = "Checkpoints: " + pCheckpointNum;
		pCheckpointNum = pScript.checkpointNum;

        pointTimer = pointTimer + Time.deltaTime;

        if (pCheckpointNum == 6)
        {
            hasPassed = false;
            //pScript.checkpointNum = 0;
            pCheckpointNum = 0;
        }

        Debug.Log("pCheckpoints: " + pCheckpointNum);
    }

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log ("HIT!");
		if ((other.gameObject.tag == "Player") && (hasPassed == false) && pointTimer > 1.5f)
		{
            pointTimer = 0.0f;
			pScript.checkpointNum++;
			pCheckpointNum = pCheckpointNum + 1;
			checkpointText.text = "Checkpoints: " + pCheckpointNum + "/6";
			hasPassed = true;
		}
	}
}

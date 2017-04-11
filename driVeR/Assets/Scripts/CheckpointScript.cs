using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckpointScript : MonoBehaviour {

	public PlayerScript pScript;
	public float pCheckpointNum;
	public Text checkpointText;

	public bool hasPassed;

	// Use this for initialization
	void Start () {
		pScript = FindObjectOfType<PlayerScript>();
		pCheckpointNum = pScript.checkpointNum;

		hasPassed = false;

		//checkpointText.text = "Checkpoints: 0";
	}

	// Update is called once per frame
	void Update () {
		//checkpointText.text = "Checkpoints: " + pCheckpointNum;
		pCheckpointNum = pScript.checkpointNum;
	}

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log ("HIT!");
		if ((other.gameObject.tag == "Player") && (hasPassed == false))
		{
			pScript.checkpointNum++;
			pCheckpointNum = pCheckpointNum + 1;
			checkpointText.text = "Checkpoints: " + pCheckpointNum + "/6";
			hasPassed = true;
		}
	}
}

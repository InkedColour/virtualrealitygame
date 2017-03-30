using UnityEngine;
using System.Collections;

public class CheckpointScript : MonoBehaviour {

	public PlayerScript pScript;
    public BoxCollider triggerPoint;
    public float pCheckpointNum;

	private bool hasPassed;

	// Use this for initialization
	void Start () {
        pScript = FindObjectOfType<PlayerScript>();
        triggerPoint = gameObject.GetComponent<BoxCollider>();
        pCheckpointNum = pScript.checkpointNum;

		hasPassed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && hasPassed == false)
        {
			pCheckpointNum = pCheckpointNum + 1;
			hasPassed = true;
        }
    }
}

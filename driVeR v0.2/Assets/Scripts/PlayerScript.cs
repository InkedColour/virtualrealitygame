using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    public float checkpointNum;
	public Text checkpointText;

	// Use this for initialization
	void Start () {
        checkpointNum = 0;
		checkpointText.text = "Checkpoints: 0/6";
	}
	
	// Update is called once per frame
	void Update () {

	    
	}
}

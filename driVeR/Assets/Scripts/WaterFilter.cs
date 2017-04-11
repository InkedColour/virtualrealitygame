using UnityEngine;
using System.Collections;

public class WaterFilter : MonoBehaviour {

    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= -5)
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }
    }
}

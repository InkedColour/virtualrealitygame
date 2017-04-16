using UnityEngine;
using System.Collections;

public class RadioScript : MonoBehaviour {

    public AudioClip[] music;
    public AudioSource radio;
    int x;
    bool songPlay = false;
    float delay = 0.0f;
    public AudioClip temp;


    // Use this for initialization
    void Start () {
        //music = new AudioClip[10];

        float rand = (Random.Range(0f, 6f));
        x = (int)rand;
        temp = music[x];

        AudioSource radio = GetComponent<AudioSource>();
        radio.clip = temp;
        radio.Play();
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}

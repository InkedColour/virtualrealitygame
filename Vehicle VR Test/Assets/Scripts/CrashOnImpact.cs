using UnityEngine;
using System.Collections;

public class CrashOnImpact : MonoBehaviour {

    //gets audio source (player)
    public AudioSource audio;
	//public AudioSource bulletAudio;

    //gets audio for gunshots
    public AudioClip impact;
	//public AudioClip bulletImpact;

    // Use this for initialization
    void Start () {
        //audio = GetComponent<AudioSource>();
    }
    Collision col;

    void OnCollisionEnter(Collision col)
    {
		if ( col.gameObject.tag == "Env")
        {
            audio.PlayOneShot(impact, 0.3f);
        }
		/*if (col.gameObject.tag == "EnemyBullet") 
		{
			bulletAudio.PlayOneShot (bulletImpact, 0.3f);
		}*/
        
    }
    
    // Update is called once per frame
    void Update () {
		if (col.gameObject.tag == "Env")
        {
            audio.PlayOneShot(impact, 0.3f);
        }
		
    }
}

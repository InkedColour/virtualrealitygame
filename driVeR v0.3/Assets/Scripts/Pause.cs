using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pause : MonoBehaviour 
{
	bool paused = false;

	void Update()
	{
		if(Input.GetButtonDown("pauseButton"))
			paused = togglePause();

        if(Input.GetButtonDown("resetButton"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

	void OnGUI()
	{
		if(paused)
		{
			GUILayout.Label("Game is paused!");
			if(GUILayout.Button("Click me to unpause"))
				paused = togglePause();
		}
	}

	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}

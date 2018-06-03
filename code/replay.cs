using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F1))
		{
			SceneManager.LoadScene ("startscene", LoadSceneMode.Single);
		}
	}
}

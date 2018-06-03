using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class aaa : MonoBehaviour { // 씬 전환 관련 스크립트

	private AudioSource audio;
	public AudioClip menu_click_sound;
	public Dropdown mapDrop;
	private static int saveindex = 0;

	// Use this for initialization

	void Start () {
		this.audio = this.gameObject.AddComponent<AudioSource>();
		this.audio.clip = menu_click_sound;
		this.audio.loop = false;
		this.audio.pitch = 1.6f;

		mapDrop.onValueChanged.AddListener 
		(
			delegate
			{
			mapDropValueChangedHandler (mapDrop);
		    }
		);

	}

	void Destroy(){
		mapDrop.onValueChanged.RemoveAllListeners ();
	}
	
	private void mapDropValueChangedHandler(Dropdown target)
	{
		saveindex = target.value;
	}

	public int getDropdownIndex(){
		return saveindex;
	}
		
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetMouseButtonDown(0))
		audio.PlayOneShot (menu_click_sound);
	}
	public void change()
	{
		SceneManager.LoadScene ("game_explain",LoadSceneMode.Single);
	}
	public void change1()
	{
		SceneManager.LoadScene ("play_1",LoadSceneMode.Single);
	}
	public void change2() 
	{
		SceneManager.LoadScene ("startscene",LoadSceneMode.Single);
	}

	public void changeindex0() 
	{
		

		if (getDropdownIndex () == 0) {
			SceneManager.LoadScene ("basic", LoadSceneMode.Single);
		}
	
		if (getDropdownIndex () == 1) {
			SceneManager.LoadScene ("map2", LoadSceneMode.Single);
		}

		if (getDropdownIndex () == 2) {
			SceneManager.LoadScene ("map3", LoadSceneMode.Single);
		}
		int ran;
		ran = Random.Range (3, 5);
		if (getDropdownIndex () == 3) {
			SceneManager.LoadScene (ran, LoadSceneMode.Single);
		}
	}

}

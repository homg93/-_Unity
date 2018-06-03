using UnityEngine;
using System.Collections;

public class bk_ball_100 : MonoBehaviour { // 알배치 관련 스크립트
	public GameObject prefab1 = null;
	public GameObject prefab2 = null;
	public GameObject prefab3 = null;
	public GameObject prefab4 = null;
	public GameObject prefab5 = null;

	public static int bk_score = 0;
	// Use this for initialization
	void Start () {
		//Debug.Log (count.check_2);
		bk_score = count.check_2 + count.check_3 +1;  //총합 알
		switch (count.check_2) //상점에서 구입한 100검은알의 갯수를 참조
		{
		case 1:
			transform.position = new Vector3 (-5.0f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			break;
		case 2:
			transform.position = new Vector3 (-5.0f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, 5.7f);
			Instantiate (prefab2,transform.position,Quaternion.identity);
			break;
		case 3:
			transform.position = new Vector3 (-5.0f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, 5.7f);
			Instantiate (prefab2,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, -3.3f);
			Instantiate (prefab3,transform.position,Quaternion.identity);
			break;
		case 4:
			transform.position = new Vector3 (-5.0f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, 5.7f);
			Instantiate (prefab2,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, -3.3f);
			Instantiate (prefab3,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, 11.9f);
			Instantiate (prefab4,transform.position,Quaternion.identity);
			break;
		case 5:
			transform.position = new Vector3 (-5.0f, 5.0f, 1.3f);
			Instantiate (prefab1, transform.position, Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, 5.7f);
			Instantiate (prefab2, transform.position, Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, -3.3f);
			Instantiate (prefab3, transform.position, Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, 11.9f);
			Instantiate (prefab4, transform.position, Quaternion.identity);
			transform.position = new Vector3 (-5.0f, 5.0f, -9.5f);
			Instantiate (prefab5, transform.position, Quaternion.identity);
			break;


		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private GUIStyle sc = new GUIStyle ();
	void OnGUI()
	{
		GUI.color = Color.magenta;
		sc.normal.textColor = Color.red;
		sc.hover.textColor = Color.red;
		sc.fontSize = 23;
		GUI.Label (new Rect (10.0f, 35.0f, 120.0f, 120.0f), "Black Life : " + bk_score,sc);
	}
}

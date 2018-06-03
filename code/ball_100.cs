using UnityEngine;
using System.Collections;

public class ball_100 : MonoBehaviour {
	public GameObject prefab1 = null; // 프리팹을 저장하기위한 GameObject 변수
	public GameObject prefab2 = null;
	public GameObject prefab3 = null;
	public GameObject prefab4 = null;
	public GameObject prefab5 = null;

	public static int wh_score=0;
	// Use this for initialization
	void Start () {
		Debug.Log (count.check);
		wh_score = count.check + count.check_1 +1 ; //총합 알갯수
		switch (count.check) //상점에서 구입한 100흰알의 갯수를 참조
		{
		case 1:
			transform.position = new Vector3 (1.1f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.Euler (0, 180, 0)); // 파라미터로 들어온 절대좌표값을 쿼터니언으로 변경해주는 함수
			break;
		case 2:
			transform.position = new Vector3 (1.1f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, 5.7f);
			Instantiate (prefab2,transform.position,Quaternion.Euler (0, 180, 0));
			break;
		case 3:
			transform.position = new Vector3 (1.1f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, 5.7f);
			Instantiate (prefab2,transform.position,Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, -3.3f);
			Instantiate (prefab3,transform.position,Quaternion.Euler (0, 180, 0));
			break;
		case 4:
			transform.position = new Vector3 (1.1f, 5.0f, 1.3f);
			Instantiate (prefab1,transform.position,Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, 5.7f);
			Instantiate (prefab2,transform.position,Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, -3.3f);
			Instantiate (prefab3,transform.position,Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, 11.9f);
			Instantiate (prefab4,transform.position,Quaternion.Euler (0, 180, 0));
			break;
		case 5:
			transform.position = new Vector3 (1.1f, 5.0f, 1.3f);
			Instantiate (prefab1, transform.position, Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, 5.7f);
			Instantiate (prefab2, transform.position, Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, -3.3f);
			Instantiate (prefab3, transform.position, Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, 11.9f);
			Instantiate (prefab4, transform.position, Quaternion.Euler (0, 180, 0));
			transform.position = new Vector3 (1.1f, 5.0f, -9.5f);
			Instantiate (prefab5, transform.position, Quaternion.Euler (0, 180, 0));
			break;
		}
	}

	// Update is called once per frame
	void Update () {
	}

	private GUIStyle sc = new GUIStyle ();
	private GUIStyle hc = new GUIStyle ();
	void OnGUI()
	{
		GUI.color = Color.magenta;
		sc.normal.textColor = Color.red;
		sc.hover.textColor = Color.red;
		sc.fontSize = 23;
		hc.normal.textColor = Color.blue;
		hc.hover.textColor = Color.blue;
		hc.fontSize = 40;
		GUI.Label (new Rect (10.0f, 10.0f, 120.0f, 120.0f), "White Life : " + wh_score,sc);
		if (DragAndDrop.wh_skill_count != 0) 
		{
			GUI.Label (new Rect (10.0f, 80.0f, 120.0f, 120.0f), "White Skill Point : " + DragAndDrop.wh_skill_count, sc);
		} else if (DragAndDrop.wh_skill_count <= 0) 
		{
			GUI.Label (new Rect (10.0f, 80.0f, 120.0f, 120.0f), "White Skill Ben " , sc);
		}

		if (DragAndDrop.bk_skill_count != 0) 
		{
			GUI.Label (new Rect (10.0f, 110.0f, 120.0f, 120.0f), "Black Skill Point : " + DragAndDrop.bk_skill_count,sc);
		} else if (DragAndDrop.bk_skill_count <= 0) 
		{
			GUI.Label (new Rect (10.0f, 110.0f, 120.0f, 120.0f), "Black Skill Ben ",sc);
		}

		if (DragAndDrop.turn % 2 == 0) {
			GUI.Label (new Rect (30.0f, 180.0f, 120.0f, 120.0f), "Black Turn",hc);
		}
		else if(DragAndDrop.turn % 2 == 1) {
			GUI.Label (new Rect (30.0f, 180.0f, 120.0f, 120.0f), "White Turn",hc);
		}

	}
}

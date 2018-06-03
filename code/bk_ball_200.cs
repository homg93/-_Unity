using UnityEngine;
using System.Collections;

public class bk_ball_200 : MonoBehaviour { // 알 배치 관련 스크립트
	public GameObject prefab1 = null;
	public GameObject prefab2 = null;
	public GameObject prefab3 = null;
	// Use this for initialization
	void Start () {
		switch (count.check_3) //상점에서 구입한 100검은알의 갯수를 참조
		{
		case 1:
			transform.position = new Vector3 (-8.4f, 5.0f, 1.2f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			break;
		case 2:
			transform.position = new Vector3 (-8.4f, 5.0f, 1.2f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-8.4f, 5.0f, -6.5f);
			Instantiate (prefab2,transform.position,Quaternion.identity);
			break;
		case 3:
			transform.position = new Vector3 (-8.4f, 5.0f, 1.2f);
			Instantiate (prefab1,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-8.4f, 5.0f, -6.5f);
			Instantiate (prefab2,transform.position,Quaternion.identity);
			transform.position = new Vector3 (-8.4f, 5.0f, 8.9f);
			Instantiate (prefab3,transform.position,Quaternion.identity);
			break;

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

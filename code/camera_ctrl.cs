using UnityEngine;
using System.Collections;

public class camera_ctrl : MonoBehaviour { // 알 배치 관련 스크립트
	private static int cnt =1;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Tab)) {
			if (cnt % 4 == 0) {	//black 기준
				this.transform.position = (new Vector3 (14.4f,23.7f,-0.1f));
				this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
			}	

			else if (cnt % 4 == 1) {
				this.transform.position = (new Vector3 (-2.9f,23.7f,-14.0f));
				this.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);

			}
			else if (cnt % 4 == 2) { //white 기준
				this.transform.position = (new Vector3 (-17.0f, 23.7f, 2.7f));
				this.transform.rotation = Quaternion.Euler (0.0f, 180.0f, 0.0f);

			}
			else if (cnt % 4 == 3) {
				this.transform.position = (new Vector3 (0.0f,23.7f,17.2f));
				this.transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);

			}
			cnt++;
		}
	}
}

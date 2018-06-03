using UnityEngine;
using System.Collections;

public class camera_ray : MonoBehaviour { // 시점변경을 위한 카메라 설정 관련 스크립트
	public Camera MainCamera = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (null != MainCamera)
		{
			Vector3 CVPos = Input.mousePosition;

			CVPos.z += 25f;

			CVPos = MainCamera.ScreenToWorldPoint(CVPos);

			// CVPos.z = 0f;

			gameObject.transform.localPosition = CVPos;

			// Debug.Log(CVPos);
		}
		// Debug.Log(Input.mousePosition);

	}
}

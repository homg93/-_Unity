using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour { // 밖으로 떨어진 알에 대한 처리 관련 스크립트
	private AudioSource audio;
	public AudioClip drop_sound;

	// Use this for initialization
	void Start () {
		this.audio = this.gameObject.AddComponent<AudioSource>();

		this.audio.loop = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other)//바닥면과 충돌된 알을 판단하기위한 함수
	{
		
		if (other.transform.tag == "Black" || other.transform.tag == "White") 
		{
			Destroy(other.gameObject);
			if (other.transform.tag == "Black") {
				audio.PlayOneShot (drop_sound);
				bk_ball_100.bk_score--;
			} else if (other.transform.tag == "White") {
				audio.PlayOneShot (drop_sound);
				ball_100.wh_score--;
			}
		}
	}

}

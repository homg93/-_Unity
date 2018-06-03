using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DragAndDrop : MonoBehaviour{
	private AudioSource audio;
	public AudioClip power_sound;
	public AudioClip click_sound;
	public AudioClip fire_sound;
	public AudioClip hit_sound;
	public AudioClip powerup_sound;
	public AudioClip nuclear_sound;

	private bool _mouseState;
	public GameObject target;
	public Vector3 screenSpace;
	public Vector3 offset;
	private float power;
	private float power_plus = 1400.0f;
	public Slider guage;
	private float rot_speed=40;
	private float unit_rotation;
	public static int turn = 0;
	public float radius = 10.0f;
	public float skillpower = 500.0f;
	public static int wh_skill_count =2;
	public static int bk_skill_count =2;
	public bool wh_check = false;
	public bool bk_check = false;
	public bool ismove = false;
	public GameObject skill_motion;
	public GameObject skill_motion1;
	public GameObject skill_motion2;
	public GameObject skill_motion3;
	public countDowntimer cdt = null;

	// Use this for initialization
	void Start (){
		target = GameObject.Find("500blackstone");

		this.audio = this.gameObject.AddComponent<AudioSource>();

		this.audio.loop = false;

		wh_skill_count = 2;
		bk_skill_count = 2;
		turn = 0;
	}

	// Update is called once per frame
	void Update (){
		setTarget ();
		ismove = false;

		if (target.tag == "Black" && turn % 2 == 0) 
		{
			setRotation ();
			if (Input.GetKey (KeyCode.C)) 
			{
				power = 0.0f;
				guage.value = 0.0f;
			} 
			else if (Input.GetKey (KeyCode.Space)) 
			{
				setPower ();
				powerUI ();
				setSound ();

			} 
			else if (Input.GetKeyUp (KeyCode.Space)) 
			{
				movePower ();
				setSound ();
				setPowerZero ();
				guage.value = 0.0f;
				turn++;
			} 
			else if (Input.GetKeyDown (KeyCode.F2) && target.name == "500blackstone" && bk_skill_count > 0) 
			{
				Instantiate (skill_motion, transform.position, transform.rotation);
				skill_collider ();
				bk_skill_count--;
				turn++;
				bk_check = true;
				ismove = true;
				setSound ();
				//cdt.setTurnTime ();
				//Debug.Log ("black : " + bk_skill_count);
			} else if (Input.GetKey (KeyCode.F3) && bk_skill_count > 0 && target.name == "500blackstone") 
			{
				setMegaPower ();
				powerUI ();
				setSound ();
			} else if (Input.GetKeyUp (KeyCode.F3)&& bk_skill_count > 0 && target.name == "500blackstone") 
			{
				Instantiate (skill_motion2, transform.position, transform.rotation);
				movePower ();
				setSound ();
				setPowerZero ();
				guage.value = 0.0f;
				turn++;
				bk_skill_count--;
			}

		} 
		else if (target.tag == "White" && turn % 2 == 1) 
		{
			setRotation ();

			if (Input.GetKey (KeyCode.C)) 
			{
				power = 0.0f;
				guage.value = 0.0f;
			} else if (Input.GetKey (KeyCode.Space)) 
			{
				setPower ();
				powerUI ();
				setSound ();

			} else if (Input.GetKeyUp (KeyCode.Space)) 
			{

				movePower ();
				setSound ();
				setPowerZero ();
				guage.value = 0.0f;
				turn++;
				ismove = true;

			} 
			else if (Input.GetKeyDown (KeyCode.F2) && target.name == "500whitestone" && wh_skill_count > 0) 
			{
				Instantiate (skill_motion1, transform.position, transform.rotation);
				skill_collider ();
				turn++;
				wh_skill_count--;
				wh_check = true;
				ismove = true;
				setSound ();
				//cdt.setTurnTime ();
				Debug.Log ("white : " + wh_skill_count);
			} else if (Input.GetKey(KeyCode.F3) &&  wh_skill_count > 0 && target.name == "500whitestone") {
				setMegaPower ();
				powerUI ();
				setSound ();
			} else if (Input.GetKeyUp (KeyCode.F3)&& wh_skill_count > 0 && target.name == "500whitestone") {
				Instantiate (skill_motion3, transform.position, transform.rotation);
				movePower ();
				setPowerZero ();
				setSound ();
				guage.value = 0.0f;
				turn++;
				wh_skill_count--;
			}
		}
	}

	void setSound(){
		if (Input.GetKeyDown (KeyCode.Space) ) {
			audio.loop = true;
			audio.PlayOneShot (power_sound);
		} 
		else if (Input.GetKeyUp (KeyCode.Space) || Input.GetKeyUp(KeyCode.F3)) 
			audio.PlayOneShot (fire_sound);
		else if (Input.GetKeyDown (KeyCode.F3))
		{
			audio.loop = true;
			audio.PlayOneShot (powerup_sound);
		}
		else if (Input.GetKeyDown (KeyCode.F2))
		{
			audio.loop = false;
			audio.PlayOneShot (nuclear_sound);
		}
		else if (Input.GetMouseButtonDown (0)) 
			audio.PlayOneShot (click_sound);
	
	}
	void OnCollisionEnter(Collision other)
	{
		audio.PlayOneShot (hit_sound);
	}

	void setTarget(){
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hitInfo;
			target = GetClickedObject (out hitInfo);
			setSound ();

			if (target != null) {
				setPowerZero();
				guage.value = 0.0f;
			}
		}

	}
	void setRotation(){
		float rot_frame = rot_speed * Time.deltaTime;
		unit_rotation = Input.GetAxis ("Horizontal");
		target.transform.Rotate (Vector3.up * unit_rotation * rot_frame);
	}

	void powerUI(){
		if (Input.GetKey (KeyCode.Space) || Input.GetKey(KeyCode.F3)) {
			guage.value += 0.015f;  //reduce health
		} else {
			guage.value = 0.0f;
		}
	}
	GameObject GetClickedObject (out RaycastHit hit){
		GameObject target = null;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray.origin, ray.direction * 10, out hit)) {
			target = hit.collider.gameObject;
		}
		return target;
	}

	void movePower(){
		target.GetComponent<Rigidbody>().AddRelativeForce(Vector3.right* power);
	}
	void setPower(){
		if (power >= 1400.0f)
			power = 1400.0f;
		else {
			power += power_plus * Time.deltaTime;
			Debug.Log (power);
		}
	}
	void setMegaPower(){
		if(power >= 2000.0f)
			power = 2000.0f;
		else {
			power += 100.0f + power_plus * Time.deltaTime;
			Debug.Log ("MegaPower" + power);
		}
	}
	void setPowerZero(){
		power = 0;
		//transform.rigidbody.velocity = 0;
	}


	void skill_collider() // 스킬 구현 부분
	{


			if (target.tag == "Black") 
			{
				
				Vector3 explosion = target.transform.position;
				Collider[] colliders = Physics.OverlapSphere (explosion, radius); // 지정한 원점을 중심으로 반경내에 있는 collider 객체들을 추출해주는 함수 유니티 API 참고
				foreach (Collider hit in colliders) 
				{
					Rigidbody skill_rb = hit.GetComponent<Rigidbody> ();

				if (skill_rb != null) {
					skill_rb.AddExplosionForce (skillpower, explosion, radius, 3.0f); // 폭발력을 전달하는 함수 AddExplosionForce(폭발력,원점,반경,위로 솟구치는 힘) 유니티 API 참고 
				}
				}
			} 
			else if (target.tag == "White") 
			{
				Vector3 explosion = target.transform.position;
				Collider[] colliders = Physics.OverlapSphere (explosion, radius);
				foreach (Collider hit in colliders) 
				{
					Rigidbody skill_rb = hit.GetComponent<Rigidbody> ();

				if (skill_rb != null) {
					skill_rb.AddExplosionForce (skillpower, explosion, radius, 3.0f);
				}
				}
			}
	}
}

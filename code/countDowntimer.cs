using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class countDowntimer : MonoBehaviour { //게임시간 및 승리패배 씬 전환 관련 스크립트
	float timeRemaining =300.0f;
	//float turnTime = 12.0f;
	float turnTime = 12.0f;
	private DragAndDrop DAD = null;
	int saveTurn =0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
		if (saveTurn == DragAndDrop.turn)
			turnTime -= Time.deltaTime;
		else if (saveTurn != DragAndDrop.turn) {
			setTurnTime (12.0f);
			saveTurn = DragAndDrop.turn;
		}


	}

	void OnGUI()
	{
		
		GUIStyle sc = new GUIStyle();


		Rect rect = new Rect (640.0f, 5.0f, 120.0f, 120.0f);

		sc.alignment = TextAnchor.UpperLeft;
		sc.fontSize = 30;
		sc.normal.textColor = Color.green;

		string text = string.Format ("Time : {0:0.0}", timeRemaining);

		if (timeRemaining > 0) 
		{
			GUI.Label (rect, text, sc);
			if (bk_ball_100.bk_score == 0)
				SceneManager.LoadScene ("1p_win", LoadSceneMode.Single);
			else if (ball_100.wh_score == 0)
				SceneManager.LoadScene ("2p_win", LoadSceneMode.Single);
		}
			
		else
		{
			if (ball_100.wh_score > bk_ball_100.bk_score) {
				SceneManager.LoadScene ("1p_win", LoadSceneMode.Single);
			} 
			else if (ball_100.wh_score < bk_ball_100.bk_score) {
				SceneManager.LoadScene ("2p_win", LoadSceneMode.Single);
			} 
			else if (ball_100.wh_score == bk_ball_100.bk_score) {
				SceneManager.LoadScene ("draw", LoadSceneMode.Single);
			}
		}

		GUIStyle hc = new GUIStyle ();
		hc.alignment = TextAnchor.UpperLeft;
		hc.fontSize = 20;
		hc.normal.textColor = Color.yellow;
		string text2 = string.Format ("제한시간 : {0:0}", turnTime);

		GUI.Label (new Rect (670.0f, 35.0f, 120.0f, 120.0f), text2, hc);

		if (turnTime < 0) {
			DragAndDrop.turn += 1;

			turnTime = 12.0f;

		}
	}
	public float setTurnTime(float time){
		turnTime = time;
		return turnTime;
	}
}

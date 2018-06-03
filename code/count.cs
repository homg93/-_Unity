using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class count : MonoBehaviour { // 구입한 알의 갯수와 돈을 계산하는 스크립트
	private int reo_count;
	public static int check;
	public static int check_1;
	public static int check_2;
	public static int check_3;
	private static int moneyb;
	private static int moneyw;
	// Use this for initialization

	void Start () {
		reo_count = 0;
		moneyb = 1100;
		moneyw = 1100;
	}
	// Update is called once per frame
	void Update () {

	}
	public void wh_plus_100() //  100흰돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalw = GameObject.Find("total1").GetComponent<Text> ();
		if (moneyw < 100)
			return;
		else if (reo_count == 5)
			return;
		else {
			moneyw -= 100;
			reo_count++;
		}
		totalw.text = moneyw.ToString ();
		check3.text = reo_count.ToString ();
		check = int.Parse(check3.text); 
	}
	public void wh_minus_100() //  100흰돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalw = GameObject.Find("total1").GetComponent<Text> ();
		if (reo_count == 0) {
			return;
		} 

		reo_count--;
		moneyw += 100;
		totalw.text = moneyw.ToString ();
		check3.text = reo_count.ToString ();
		check = int.Parse(check3.text);
	}
	public void wh_plus_200() //  200흰돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalw = GameObject.Find("total1").GetComponent<Text> ();
		if (moneyw < 200)
			return;
		else if (reo_count == 3)
			return;
		else {
			moneyw -= 200;
			reo_count++;

		}
		totalw.text = moneyw.ToString ();
		check3.text = reo_count.ToString ();
		check_1 = int.Parse(check3.text); 
	}
	public void wh_minus_200() //  200흰돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalw = GameObject.Find("total1").GetComponent<Text> ();
		if (reo_count == 0 ) {
			return;
		}
		reo_count--;
		moneyw += 200;
		totalw.text = moneyw.ToString ();
		check3.text = reo_count.ToString ();
		check_1 = int.Parse (check3.text); 
	}
	public void bk_plus_100() //  100검은돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalb = GameObject.Find("total").GetComponent<Text> ();
		if (moneyb < 100)
			return;
		else if (reo_count == 5)
			return;
		else {
			moneyb -= 100;
			reo_count++;
		}
		totalb.text = moneyb.ToString ();
		check3.text = reo_count.ToString ();
		check_2 = int.Parse(check3.text); 
	}
	public void bk_minus_100() // 100검은돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalb = GameObject.Find("total").GetComponent<Text> ();
		if (reo_count == 0) {
			return;
		} 

		reo_count--;
		moneyb += 100;
		totalb.text = moneyb.ToString ();
		check3.text = reo_count.ToString ();
		check_2 = int.Parse(check3.text); 

	}

	public void bk_plus_200() // 200검은돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalb = GameObject.Find("total").GetComponent<Text> ();
		if (moneyb < 200)
			return;
		else if (reo_count == 3)
			return;
		else {
			moneyb -= 200;
			reo_count++;

		}
		totalb.text = moneyb.ToString ();
		check3.text = reo_count.ToString ();
		check_3 = int.Parse(check3.text); 
	}
	public void bk_minus_200() // 200검은돌 갯수카운트
	{
		Text check3 = GetComponent<Text> ();
		Text totalb = GameObject.Find("total").GetComponent<Text> ();
		if (reo_count == 0 ) {
				return;
		}
		reo_count--;
		moneyb += 200;
		totalb.text = moneyb.ToString ();
		check3.text = reo_count.ToString ();
		check_3 = int.Parse (check3.text); 
	}
}

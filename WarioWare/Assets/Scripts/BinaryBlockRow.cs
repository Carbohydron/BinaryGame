using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BinaryBlockRow : MonoBehaviour
{
		NumBlock[] blockarr = new NumBlock[8];
		Canvas c;
		GameObject goaltxt;
		GameObject txt;
		RectTransform txtrt;
		private Text rowtotal;
		public bool hard;
		RectTransform rowtransform;

		int goalnum = 1;
		int currentVal = 0;
		
		void Start ()
		{	
				rowtransform = gameObject.GetComponent<RectTransform> ();
				c = gameObject.GetComponentInParent<Canvas> ();
				if (!hard) {
						txt = Instantiate (Resources.Load ("txt", typeof(GameObject))) as GameObject;
						txt.GetComponent<RectTransform> ().parent = c.transform;
						txtrt = txt.GetComponent<RectTransform> ();
						txtrt.localPosition = new Vector3 (rowtransform.localPosition.x + rowtransform.rect.width / 2 + txtrt.rect.width / 2 + 5, rowtransform.localPosition.y - 5, 0);
						txtrt.localScale = new Vector3 (1, 1, 1);
						
						rowtotal = txt.GetComponent<Text> ();
				}
				blockarr = gameObject.GetComponentsInChildren<NumBlock> ();
				

				goaltxt = Instantiate (Resources.Load ("txt", typeof(GameObject))) as GameObject;
				goaltxt.GetComponent<RectTransform> ().parent = c.transform;
				
				RectTransform goaltxtrt = goaltxt.GetComponent<RectTransform> ();
			
				goaltxtrt.localPosition = new Vector3 (txtrt.localPosition.x + txtrt.rect.width + 5, txtrt.localPosition.y, 0);
				goaltxtrt.localScale = new Vector3 (1, 1, 1);
		}
	
		// Update is called once per frame
		void Update ()
		{

				Text goaltxttemp = goaltxt.GetComponent<Text> ();
				goaltxttemp.text = goalnum.ToString ();
			
				currentVal = 0;
				for (int a =0; a<8; ++a) {
						if (blockarr [a].getValue () == 1) {
								currentVal += (int)System.Math.Pow (2, a);
						}
				}
				if (!hard) {
						rowtotal.fontStyle = FontStyle.Normal;
						rowtotal.text = currentVal.ToString ();
				}
			
		}

		private void rowSolved ()
		{
			
		}

		public int Goalnum {
				get {
						return goalnum;
				}

				set {
						goalnum = value;
				}
		}

		public int CurrentVal {
				get {
						return currentVal;
				}
		}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BinaryBlockRow : MonoBehaviour
{
		NumBlock[] blockarr = new NumBlock[8];
		Canvas c;
		GameObject txt;
		RectTransform txtrt;
		private Text rowtotal;
		public bool hard;
		RectTransform rowtransform;
		
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

		}
	
		// Update is called once per frame
		void Update ()
		{
				
				int num = 0;
				for (int a =0; a<8; ++a) {
						if (blockarr [a].getValue () == 1) {
								num += (int)System.Math.Pow (2, a);
						}
				}
				rowtotal.text = num.ToString ();
		}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BinaryGame : MonoBehaviour
{
		private bool difficult = false;
		BinaryBlockRow[] blockrows = new BinaryBlockRow[2];
		
		void Start ()
		{
				gameObject.AddComponent<BinaryBlockRow> ();

				//blockrows.Initialize ();
				//blockrows.SetValue (Instantiate (Resources.Load ("BinaryBlockRow", typeof(GameObject))) as BinaryBlockRow, 0);
			
				//bbr = Instantiate (Resources.Load ("BinaryBlockRow", typeof(GameObject))) as GameObject;
				//bbr.GetComponent<RectTransform> ().parent = gameObject.GetComponent<Canvas> ().GetComponent<RectTransform> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (!difficult) {
					
				}

				/*for (int a =0; a<blockrows.Length; ++a) {
						if (blockrows [a].CurrentVal == blockrows [a].Goalnum) {
								rowSolved (a);
						}
				}*/
		}

		private void rowSolved (int a)
		{

		}

		
}

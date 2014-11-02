using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BinaryGame : MonoBehaviour
{
		public bool difficult = false;
		BinaryBlockRow[] blockrows = new BinaryBlockRow[5];
		
		void Start ()
		{
				BinaryBlockRow temp;
				for (int a =0; a<blockrows.Length; ++a) {
						temp = gameObject.AddComponent<BinaryBlockRow> ();
						blockrows.SetValue (temp, a);
				}

				for (int a =0; a< blockrows.Length; ++a) {
						if (blockrows [a] != null) {
								Vector3 tempv = new Vector3 (-100, -220 + a * 100, 0);
								blockrows [a].updatePos (tempv);
						}
				}

		}
	
		// Update is called once per frame
		void Update ()
		{
				for (int a =0; a<blockrows.Length; ++a) {
						if (blockrows [a] != null) {
								Vector3 temp = new Vector3 (-100, -220 + a * 100, 0);
								//blockrows [a].updatePos (temp);

								blockrows [a].Rowtransform.localPosition = Vector3.Lerp (blockrows [a].Rowtransform.localPosition, temp, Time.deltaTime);
								blockrows [a].Txtrt.localPosition = Vector3.Lerp (blockrows [a].Txtrt.localPosition, new Vector3 (temp.x + blockrows [a].Rowtransform.rect.width / 2 + blockrows [a].Txtrt.rect.width / 2 + 5, temp.y - 5, 0), Time.deltaTime);
								blockrows [a].Goaltxtrt.localPosition = Vector3.Lerp (blockrows [a].Goaltxtrt.localPosition, new Vector3 (blockrows [a].Txtrt.localPosition.x + blockrows [a].Txtrt.rect.width + 5, blockrows [a].Txtrt.localPosition.y, 0), Time.deltaTime);
								blockrows [a].updateDifficulty (difficult);
						}
				}
				
				for (int a =0; a<blockrows.Length; ++a) {
						//Debug.Log (a.ToString () + " val: " + blockrows [a].CurrentVal.ToString ());
						if (blockrows [a] != null) {
								if (blockrows [a].CurrentVal == blockrows [a].Goalnum) {
										rowSolved (a);
								}
						}
				}
		}

		private void rowSolved (int a)
		{
				if (blockrows [a] != null)
						blockrows [a].rowSolved ();
				blockrows [a] = null;
				Invoke ("shiftRows", 2f);		


		}

		private void shiftRows ()
		{
				bool flag = true;
				int num = 0;
				for (int a =0; a<blockrows.Length && flag; ++a) {
						if (blockrows [a] == null) {
								flag = false;
								num = a;
						}
				}

				for (int i =num; i<blockrows.Length-1; ++i) {
						blockrows [i] = blockrows [i + 1];
				}
				blockrows [blockrows.Length - 1] = null;

		}

		
}

using UnityEngine;
using System.Collections;

public class BinaryGame : MonoBehaviour
{
		private bool difficult = false;
		public GameObject blockPrefab;
		BinaryBlockRow[] blockrows = new BinaryBlockRow[1];
		
		void Start ()
		{
				blockrows [0] = Instantiate (Resources.Load ("BinaryBlockRow", typeof(GameObject))) as BinaryBlockRow;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (!difficult) {
					
				}

				for (int a =0; a<blockrows.Length; ++a) {
						if (blockrows [a].CurrentVal == blockrows [a].Goalnum) {
								rowSolved (a);
						}
				}
		}

		private void rowSolved (int a)
		{

		}

		
}

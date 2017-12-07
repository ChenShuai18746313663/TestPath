using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class DebPath : MonoBehaviour {

	public Text text;
	public Text text1;

	// Use this for initialization
	void Start () {

		StreamWriter sw = new StreamWriter (Application.streamingAssetsPath + "/Lua.txt");

		try {
			sw.Write("223445");;
		} catch (System.Exception ex) {
			text1.text = ex.ToString ();
		}
		sw.Close ();


		StreamReader sr = new StreamReader (Application.streamingAssetsPath + "/Lua.txt", System.Text.Encoding.UTF8);
		string str = "";
		try {
			str = sr.ReadToEnd();
		} catch (System.Exception ex) {
			text1.text = ex.ToString ();
		}
		sr.Close ();


		#if UNITY_EDITOR
		text.text = Application.streamingAssetsPath;
		text1.text = Application.persistentDataPath;
		#elif UNITY_STANDALONE_WIN
		text.text = Application.streamingAssetsPath;
		text1.text = Application.persistentDataPath;
		#endif


		text.text =str;
		text1.text = Application.persistentDataPath;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

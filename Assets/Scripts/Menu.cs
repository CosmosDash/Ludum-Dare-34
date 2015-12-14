using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public Canvas MainCanvas;

	public void LoadGame()
	{
		Application.LoadLevel (3);
	}

	public void LoadFr()
	{
		Application.LoadLevel(4);
	}

	public void LoadTwitter()
	{
		Application.OpenURL ("http://twitter.com/cosmosdash");
	}
}

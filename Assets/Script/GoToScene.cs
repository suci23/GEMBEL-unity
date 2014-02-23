using UnityEngine;
using System.Collections;

public class GoToScene : MonoBehaviour {

  
	public string sceneName;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown(){
	}
	void OnMouseUpAsButton(){
		Application.LoadLevel(sceneName);
	}
    
}

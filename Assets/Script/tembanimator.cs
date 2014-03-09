using UnityEngine;
using System.Collections;

public class tembanimator : MonoBehaviour {

	public Sprite[] sprites;
	public float framesPerSecond;
	private SpriteRenderer spriteRenderer;
	public string sceneName;

	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUpAsButton(){
		//print ("hai");
		int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
		if (index < 3) {
						index = index % sprites.Length;
						spriteRenderer.sprite = sprites [index];
				}
		if(index == 3){
			Application.LoadLevel(sceneName);
		}
	}
}

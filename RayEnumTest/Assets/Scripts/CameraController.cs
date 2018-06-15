using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rot = new Vector3(Mathf.Clamp((-(Input.mousePosition.y-Screen.height/2))/2+20, -15, 60), Mathf.Clamp((Input.mousePosition.x- Screen.width / 2)/2, -65, 65), 0);
        this.transform.rotation = Quaternion.Euler(rot);
	}
}

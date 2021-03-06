using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	void Update () 
	{
		float newY = Mathf.Sin(Time.time * 0.7f) * 0.5f + this.transform.position.y;
		transform.Rotate (new Vector3 (15, newY, 100) * Time.deltaTime);
        //set the object's Y to the new calculated Y
        //transform.position=new Vector3(this.x, newY, this.z) * Time.deltaTime;
	}
}
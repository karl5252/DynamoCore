using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Hotizontal : MonoBehaviour
{
    public Vector3 startingPosition;
    public enum OccilationFuntion { Sine, Cosine }
    public void Start()
    {
        //to set starting ppsition
        startingPosition = this.transform.position;
        //to start at zero
        StartCoroutine(Oscillate(OccilationFuntion.Sine, 5f));
        //to start at scalar value
        //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 10f));
    }

    private IEnumerator Oscillate(OccilationFuntion method, float scalar)
    {
        while (true)
        {
            if (method == OccilationFuntion.Sine)
            {
                transform.position = new Vector3(Mathf.Sin(Time.time) * scalar, this.transform.position.y, this.transform.position.z);
            }
            else if (method == OccilationFuntion.Cosine)
            {
                transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, this.transform.position.y, this.transform.position.z);
            }
            yield return null;
        }
    }
}

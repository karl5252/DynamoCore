using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Vertical : MonoBehaviour
{
    public enum OccilationFuntion { Sine, Cosine }
    public void Start()
    {
        //to start at zero
        StartCoroutine(Oscillate(OccilationFuntion.Sine, 5f));
        //to start at scalar value
        //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
    }

    private IEnumerator Oscillate(OccilationFuntion method, float scalar)
    {
        while (true)
        {
            if (method == OccilationFuntion.Sine)
            {
                transform.position = new Vector3(this.transform.position.x, Mathf.Sin(Time.time) * scalar, this.transform.position.z);
            }
            else if (method == OccilationFuntion.Cosine)
            {
                transform.position = new Vector3(this.transform.position.x, Mathf.Cos(Time.time) * scalar, this.transform.position.z);
            }
            yield return null;
        }
    }
}

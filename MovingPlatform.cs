using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    Transform platform;
    [SerializeField]
    Transform startTransform;
    [SerializeField]
    Transform endTransform;
    [SerializeField]
    float moveSpeed;

    Vector3 direction;
    Transform destination;

    private void Start()
    {
        SetDestination(startTransform);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {     
        platform.GetComponent<Rigidbody>().MovePosition(platform.position + direction * moveSpeed * Time.deltaTime);
        if(Vector3.Distance(platform.position, destination.position)< moveSpeed * Time.deltaTime)
        {
            SetDestination(destination == startTransform ? endTransform : startTransform);
        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(startTransform.position,platform.localScale);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(endTransform.position, platform.localScale);

    }
    void SetDestination(Transform target)
    {
        destination = target;
        direction = (destination.position - platform.position).normalized;
    }

    


}

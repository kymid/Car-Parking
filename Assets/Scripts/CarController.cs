using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public LayerMask mask;


    public bool isActive;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void CheckMove(bool isForward)
    {
        int a = isForward ? 1 : -1;

        Ray ray = new Ray(transform.position, transform.right * a);

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, mask))
        {
            CarMove(DistanceToHit(hit));
        }

    }

    private int DistanceToHit(RaycastHit hit)
    {
        int distance = (int) (hit.distance - transform.lossyScale.x / 2);
        Debug.Log($" {distance}  beatween  {transform.name} --> {hit.collider.name}");
        return distance;
    }

    private void CarMove(int distance)
    {
        if(distance != 0)
        {
            // DoMove
        }

        //dtp
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.right * 2);

        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, -transform.right * 2);

    }
}

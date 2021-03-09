using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    //Behaviour for the grapple hook.

    public LayerMask grappleSurfaces;
    public Transform grappleStart;
    public float range = 50f;
    public Camera PlayerCamera;

    private int hitInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            GrappleShoot();
        }
        
    }

    void GrappleShoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(grappleStart.position, PlayerCamera.transform.forward, out hit, range, grappleSurfaces))
        {
            hitInt += 1;
            Debug.Log("hit " + hitInt);
            Debug.DrawLine(grappleStart.position, hit.point);
        }
    }
}

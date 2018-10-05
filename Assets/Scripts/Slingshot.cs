using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    [Header("Set in inspector")]
    public GameObject prefabProjectile;

    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
    }
    void OnMouseEnter()
    {
        //print("Slingshot: OnMouseEnter ()");
        launchPoint.SetActive(true);
    }

    void OnMouseExit()
    {
        //print("Slingshot: OnMouseExit()");
        launchPoint.SetActive(false);
    }
    void OnMouseDown()
    {
        aimingMode = true;
        projectile = Instantiate( prefabProjectile ) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent< Rigidbody > ().isKinematic = true;

    }
}
using UnityEngine;
using System.Collections;


public class SlingShot : MonoBehaviour
{
    public GameObject launchPoint;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");

        launchPoint = launchPointTrans.gameObject;

        launchPoint.SetActive(false);
    }
    void OnMouseEnter()
    {
        
        print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);

    }
    
    void OnMouseExit()
    {

        print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVScript : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("hero");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jarakCctvHero = target.transform.position - transform.position;
        Quaternion rot = Quaternion.LookRotation(jarakCctvHero);
        // transform.rotation = Quaternion.Euler(0, rot.eulerAngles.y, 0);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, rot.eulerAngles.y, 0), 10f * Time.deltaTime);
        Debug.DrawRay(transform.position, jarakCctvHero, Color.red);
    }
}

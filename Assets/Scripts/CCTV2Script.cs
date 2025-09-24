using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV2Script : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("hero");
        transform.rotation = Quaternion.AngleAxis(45, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jarakCctvHero = target.transform.position - transform.position;
        float angle = Mathf.Atan2(jarakCctvHero.x, jarakCctvHero.z) * Mathf.Rad2Deg;

        Quaternion rotasi = Quaternion.AngleAxis(angle, Vector3.up);
        // transform.rotation = rotasi;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotasi, Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVScript : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 jarakCctvHero = target.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.LookRotation(jarakCctvHero);
        Debug.DrawRay(this.transform.position, jarakCctvHero, Color.red);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(0, 0, v) * Time.deltaTime * 3f);
        this.transform.Rotate(new Vector3(0, h, 0) * 5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("hero");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 50;
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            speed = -50;
        }
        transform.LookAt(hero.transform);
        transform.RotateAround(hero.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}

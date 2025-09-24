using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject hero;

    private float currentDistance;
    private Vector3 offset;
    private float zoomSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("hero");

        offset = transform.position - hero.transform.position;
        currentDistance = offset.magnitude;
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

        if (Input.GetKey(KeyCode.UpArrow))
        {
            currentDistance -= zoomSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentDistance += zoomSpeed * Time.deltaTime;
        }

        offset = offset.normalized * currentDistance;

        transform.position = hero.transform.position + offset;

        transform.LookAt(hero.transform);
        transform.RotateAround(hero.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}

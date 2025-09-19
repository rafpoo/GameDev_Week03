using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0));
        Debug.Log("Rotasi Y Hero: " + transform.eulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusuhScript : MonoBehaviour
{
    bool gerakKanan = false;
    float posAwalX;
    float jarakGerakMusuh = 7f;
    // Start is called before the first frame update
    void Start()
    {
        posAwalX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (gerakKanan == false)
        {
            transform.Translate(new Vector3(3f, 0, 0) * Time.deltaTime);
            if (transform.position.x > posAwalX + jarakGerakMusuh)
            {
                gerakKanan = true;
            }
        }
        else
        {
            transform.Translate(new Vector3(-3f, 0, 0) * Time.deltaTime);
            if (transform.position.x < posAwalX - jarakGerakMusuh)
            {
                gerakKanan = false;
            }
        }
    }
}

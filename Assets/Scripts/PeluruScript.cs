using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruScript : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        // haps peluru setelah gbeberapa detik
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("musuh"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

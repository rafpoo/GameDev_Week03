using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float fireRate = 1f;
    private float fireTimer = 0f;

    GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 posTarget = target.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(posTarget);

            fireTimer += Time.deltaTime;
            if (fireTimer >= fireRate)
            {
                Shoot();
                fireTimer = 0f;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("musuh"))
        {
            target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == target)
        {
            target = null;
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && shootPoint != null)
        {
            Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        }
    }
}

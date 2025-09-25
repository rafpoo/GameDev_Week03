using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject movepoint;
    List<GameObject> listPoint = new List<GameObject>();
    float speedMove = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        movepoint = GameObject.Find("movepoint");

        // save smua child point pada movepoint di array list
        foreach (Transform child in movepoint.transform)
        {
            listPoint.Add(child.gameObject);
        }

        // lihat di list
        foreach (GameObject x in listPoint)
        {
            Debug.Log("list: " + x.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (listPoint.Count > 0)
        {
            // modifikasi moveTowards, gerakan musuh ke point, hanya gerakan axis x dan z
            Vector3 targetPos = new Vector3(listPoint[0].transform.position.x, transform.position.y, listPoint[0].transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speedMove * Time.deltaTime);

            // hadap musuh
            Vector3 posPoint = targetPos - transform.position;
            transform.rotation = Quaternion.LookRotation(posPoint);

            // modifikasi vector3.distance hanya melihat posisi x dan z, apakah sudah sampai tujauan
            Vector3 posMusuh = transform.position;
            posMusuh.y = listPoint[0].transform.position.y;
            if (Vector3.Distance(listPoint[0].transform.position, posMusuh) < 0.1f)
            {
                listPoint.RemoveAt(0);
            }
        }
        else
        {
            Debug.Log("musuh sampai tujuan");
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charger : MonoBehaviour
{
    public GameObject target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = transform.position.y - target.transform.position.y;
        if (dist > 5f)
        {
            //code to activate object
            gameObject.SetActive(true);
        }
        else if (dist < -5f)
        {
            //code to deactivate object and move back to top

            transform.position = new Vector3(Random.Range(-13f, 13f), target.transform.position.y + 15f, 0);
        }
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.02F, transform.position.z);


    }
}
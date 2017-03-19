using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Transform rect;
    private void Awake()
    {
        rect = GetComponent<Transform>();
    }
    // Use this for initialization
    void Start()
    {

        foreach (var item in this.transform)
        {
            //do something to all children
        }
    }

    // Update is called once per frame
    void Update()
    {

            var space = Input.GetKeyDown(KeyCode.UpArrow);
            var axis = Input.GetAxis("Horizontal");

        if ( (rect.position.x + axis) < 13 && (rect.position.x + axis) > -13)
        {
            rect.position = new Vector3(rect.position.x + axis, rect.position.y, rect.position.z);
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Game Over Scene");
    }
}
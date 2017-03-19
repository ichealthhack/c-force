using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boost_yes_to_blow_to_boost : MonoBehaviour {

    // Use this for initialization
    void Start () {}
    public void NextScene()
    {
        FizzyoDevice.useFizzioDevice = true;
        SceneManager.LoadScene("calibration");
    }


    // Update is called once per frame
    void Update()
    {

    }
}

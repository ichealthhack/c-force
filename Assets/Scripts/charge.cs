using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charge : MonoBehaviour {
    float start_time;
    public int charge1;
    public Text chargeText;
    public float maxFizzyoPressure;


    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
        chargeText = GetComponent<Text>();
        chargeText.text = "charge: " + 100;
        charge1 = 100;
        maxFizzyoPressure = PlayerPrefs.GetFloat("Max Fizzyo Pressure");
        Debug.Log("max = " + maxFizzyoPressure);
    }
	// Update is called once per frame
	void Update () {
        
        if (FizzyoDevice.useFizzioDevice)
        {
            charge1 = 100 - 5 * (int)(Time.time - start_time) + (int)(maxFizzyoPressure*10);
            chargeText.text = "charge: " + charge1;
            Debug.Log("charge = " + charge1);
            Debug.Log("True");
        }
        else
        {
            charge1 = 100 - 5 * (int)(Time.time - start_time);
            chargeText.text = "charge: " + charge1;
            Debug.Log("false");
        }

    }
}

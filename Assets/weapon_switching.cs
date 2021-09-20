using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_swtiching : MonoBehaviour
{
    public GameObject wep1;
    public GameObject wep2;

    // Start is called before the first frame update
    void Start()
    {
        wep1.SetActive(true);
        wep2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            wep1.SetActive(true);
            wep2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            wep1.SetActive(false);
            wep2.SetActive(true);
        }
    }
}

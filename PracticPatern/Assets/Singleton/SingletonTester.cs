using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            TestSingleton.instance.Debug();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Bank.instance.Debug();
        }


    }
}

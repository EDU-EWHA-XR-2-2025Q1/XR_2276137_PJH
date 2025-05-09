using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D13_Pick_Controller : MonoBehaviour
{
    int pickCount = 0;
    bool isInTheArea = false;

    public void Increase_PickCount(GameObject Clone)
    {
        if (isInTheArea)
        {
            pickCount++;
            print($"pickCount : {pickCount}");
            Destroy(Clone);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = true;
        }
    }

}

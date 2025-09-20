using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TurbineObject;
    private bool isActive = true;

    public void Toggle()
    {
         if(isActive)
        {
            TurbineObject.SetActive(false);
            isActive = false;
        }
        else
        {
            TurbineObject.SetActive(true);
            isActive = true;
        }
    }
}

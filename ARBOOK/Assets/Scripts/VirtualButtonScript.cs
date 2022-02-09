using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualButtonScript : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject VB1, VB2, VB3;
    // Start is called before the first frame update
    void Start()
    {
        VB1.SetActive(false);
        VB2.SetActive(false);
        VB3.SetActive(false);

        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0;i<vrb.Length;i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }

    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "VButton1")
        {
            Debug.Log("VButton1 pressed.");
            VB1.SetActive(true);
            VB2.SetActive(false);
            VB3.SetActive(false);
        }
        else if(vb.VirtualButtonName == "VButton2")
        {
            Debug.Log("VButton2 pressed.");
            VB1.SetActive(false);
            VB2.SetActive(true);
            VB3.SetActive(false);
        }
        else if (vb.VirtualButtonName == "VButton3")
        {
            Debug.Log("VButton3 pressed.");
            VB1.SetActive(false);
            VB2.SetActive(false);
            VB3.SetActive(true);
        }
        else
        {
            Debug.Log("VButton released.");
            throw new UnityException(vb.VirtualButtonName+" Virtual Button not supported.");
        }
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
    }
}

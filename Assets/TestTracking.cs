using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OculusSampleFramework;

public class TestTracking : MonoBehaviour
{
    public InteractableToolsCreator handTools;
    private GameObject fingerTip;

    // Start is called before the first frame update
    void Start()
    {
        fingerTip = FindObjectOfType<FingerTipPokeTool>().gameObject;   
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = fingerTip.transform.position;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractionFingerCollider : MonoBehaviour
{

    public GameObject sliderController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerHandLeft" || other.gameObject.tag == "PlayerHandRight")
        {
            //sliderController.BroadcastMessage("FingerOnTriggerEnter", other);
        }

        sliderController.BroadcastMessage("FingerOnTriggerEnter", other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PlayerHandLeft" || other.gameObject.tag == "PlayerHandRight")
        {
            //sliderController.BroadcastMessage("FingerOnTriggerExit", other);
        }
        sliderController.BroadcastMessage("FingerOnTriggerExit", other);
    }
}

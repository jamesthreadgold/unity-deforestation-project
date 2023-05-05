using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetIn : MonoBehaviour
{
    public GameObject PlayerStanding, PlayerIn, IntText, OutText;
    private bool interactable, sitting;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            IntText.SetActive(true);
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            IntText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerIn.SetActive(true);
                PlayerStanding.SetActive(false);
                OutText.SetActive(true);
                sitting = true;
                interactable = false;
                IntText.SetActive(false);

                //MAKE VEICHLE DRIVEABLE

                Debug.Log("Drive");

                GameObject digger = GameObject.FindGameObjectWithTag("Digger");
                digger.GetComponent<Controller>().Drivable = true;





            }
        }
        if(sitting == true)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                PlayerIn.SetActive(false);
                PlayerStanding.SetActive(true);
                OutText.SetActive(false);
                sitting = false;
                interactable = true;
                IntText.SetActive(true);

                Debug.Log("Drive");

                GameObject digger = GameObject.FindGameObjectWithTag("Digger");
                digger.GetComponent<Controller>().Drivable = false;






            }
        }
    }
}

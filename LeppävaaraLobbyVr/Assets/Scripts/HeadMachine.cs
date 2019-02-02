using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

/*
    This script rotates the heads in the head machine
    when the button is pressed    
*/

public class HeadMachine : MonoBehaviour {

    public NVRButton Button;

    public GameObject[] Heads;

    public GameObject Spinner;
    public GameObject SpawnPoint;


    private Quaternion targetRotation;

    float timer = 0;
    float maxTime = 10f;

    float ButtonOffset = 0.1f;

    void Start()
    {
        targetRotation = Spinner.transform.rotation;
        Button = gameObject.GetComponent<NVRButton>();
    }

    void Update() {
        

        if (Button.ButtonDown)
        {
            targetRotation *= Quaternion.AngleAxis(180, Vector3.forward);

            if (timer < maxTime)
            {
                timer++;
            }
            else
            {
                timer = 0;
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + ButtonOffset);
            }
        }

        Spinner.transform.rotation = Quaternion.Lerp(Spinner.transform.rotation, targetRotation, Time.deltaTime);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class toggleBtn : MonoBehaviour
{
    //gets current Toggle?
    private Toggle toggle;
    /*
 public GameObject currentTarget;
 public GameObject nextTarget;
 public UnityEvent unityEvent;


 public void hideAll()
 {
     Debug.Log("GOT IT!");
     currentTarget = GameObject.FindWithTag("BlueBox");
     nextTarget = GameObject.FindWithTag("RedBox");
     //3 is greater than the index (0)
     if (unityEvent. == false)
     {

         nextTarget.SetActive(false);
         currentTarget.SetActive(false);
     }
     else
     {
         nextTarget.SetActive(true);
         currentTarget.SetActive(true);
     }
 }
 */

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<UnityEngine.UI.Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);

    }
    private void OnToggleValueChanged(bool isOn) {
        if(isOn == true) {
            Debug.Log("HEY WERE ARE ON");
        }
        else
        {
            Debug.Log("HEY WERE ARE OFF");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

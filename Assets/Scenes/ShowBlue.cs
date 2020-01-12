using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBlue : MonoBehaviour
{
    //3
   //   [SerializeField] GameObject[] targets;
    public GameObject currentTarget;
    int targetIndex;

    //Object 
    public void showBlue()
    {
        Debug.Log("GOT IT!");
        //3 is greater than the index (0)
        if(currentTarget != null)
        {
            currentTarget = GameObject.FindWithTag("BlueBox");
            currentTarget.SetActive(false);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

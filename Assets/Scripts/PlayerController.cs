using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vor dem Return!");
        Output(GetFive());
    }

    void Output(int number)
    {
        Debug.Log(number);
    }

    int GetFive()
    {
        return 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

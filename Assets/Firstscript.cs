using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstscript : MonoBehaviour
{
    float Sum(float a, float b) {

        return a + b; }
    float Prod(float a, float b)
    {

        return a * b;
    }
    float Div(float a, float b)
    {

        if (b == 0)
        {
            Debug.Log("error");
            return 0;
        }else  
        {
            Debug.Log("return nothing");
            return a / b;
        }

        
        
    }





}

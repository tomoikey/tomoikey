using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public void LButtonDown(){
        transform.Translate(-1, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }
   
}

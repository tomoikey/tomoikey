using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class opn : MonoBehaviour
{
    float time = 0;
    
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 3.0f)
        {
            SceneManager.LoadScene("mainScene");
        }
    }
}

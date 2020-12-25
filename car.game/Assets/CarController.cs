using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;//マウスの座標(クリック時）
        }
        else if(Input.GetMouseButtonUp(0))
            {
            Vector2 endPos = Input.mousePosition;//マウスの座標(離したとき）
            float swipeLength = endPos.x - this.startPos.x;
            //スワイプを速度に変換
            this.speed = swipeLength / 800.0f;

            GetComponent<AudioSource>().Play();
        }


        
     transform.Translate(this.speed,0,0);
        this.speed *= 0.98f;

     

        }
    }


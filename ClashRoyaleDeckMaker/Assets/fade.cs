using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
    public float alpha = 0;
    float red;
    float blue;
    float green;

    float fadeSpeed = 0.01f;
    float timer = 0;

    bool flag;

    Image image;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        image = GetComponent<Image>();
        red = image.color.r;
        blue = image.color.b;
        green = image.color.g;
        alpha = image.color.a;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1.0f && alpha <= 1.0f)
        {
            flag = true;
            image.enabled = flag;
            fadeOut();
        }
    }

    private void fadeOut()
    {
        
        alpha += fadeSpeed;
        SetColor();

    }

    private void SetColor()
    {
        image.color = new Color(red, green, blue, alpha);
    }
}

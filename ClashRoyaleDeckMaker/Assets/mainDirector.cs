using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainDirector : MonoBehaviour
{
    #region 宣言
    const int width = 101; //カード枚数
    static int deckUpperLim = 8;
    List<int> number = new List<int>();
    int[] result = new int[deckUpperLim];
    readonly int[] cardNum = new int[width]
    {
        26000010,
        26000030,
        28000006,
        28000016,
        26000002,
        26000019,
        26000031,
        26000038,
        26000049,
        26000058,
        28000002,
        28000008,
        28000011,
        28000015,
        28000017,
        26000000,
        26000001,
        26000005,
        26000012,
        26000013,
        26000023,
        26000025,
        26000026,
        26000040,
        26000041,
        26000046,
        26000039,
        26000032,
        28000001,
        27000009,
        26000050,
        26000056,
        26000061,
        26000064,
        26000067,
        27000000,
        28000004,
        28000012,
        28000013,
        28000014,
        28000018,
        26000011,
        26000057,
        26000015,
        26000014,
        26000018,
        26000021,
        26000027,
        26000035,
        26000036,
        26000037,
        26000042,
        26000044,
        26000048,
        26000052,
        26000062,
        26000068,
        26000080,
        27000002,
        27000004,
        27000006,
        27000010,
        27000012,
        28000000,
        28000005,
        28000009,
        26000003,
        26000006,
        26000007,
        26000016,
        26000017,
        26000022,
        26000034,
        26000008,
        26000045,
        26000051,
        26000053,
        26000054,
        26000059,
        26000063,
        27000001,
        27000003,
        28000010,
        26000020,
        26000024,
        26000033,
        26000043,
        26000060,
        27000007,
        27000008,
        28000003,
        28000007,
        26000004,
        26000055,
        26000029,
        26000047,
        27000005,
        26000009,
        26000028,
        26000085,
        26000084
    };
    string[] answer = new string[8];

    string url;
    GameObject text;
    #endregion

    private void Start()
    {
        text = GameObject.Find("Canvas/link"); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            string a = "";

            number = new List<int>();

            for (int i = 0; i < width; ++i) //add number to list
            {
                number.Add(i);//0-98の番号が追加　０，１，２，３，...,９８
            }

            for (int i = 0; i < deckUpperLim; ++i)
            {
                int randomNum = Random.Range(0, number.Count);
                result[i] = number[randomNum];
                number.RemoveAt(randomNum);
            }

            for (int i = 0; i < result.Length; ++i)
            {
                a += "　" + result[i];
            }

            Debug.Log(a);
        }
    }

    public void RandomNum()
    {
        number=new List<int>();

        for (int i = 0; i < cardNum.Length; ++i) //add number to list
        {
            number.Add(i);
        }

        for (int i = 0; i < deckUpperLim; ++i)
        {
            int randomNum = Random.Range(0, number.Count);
            result[i] = number[randomNum];
            number.RemoveAt(randomNum);
        }

        for (int i = 0; i < result.Length; ++i)
        {
            answer[i] = $"{cardNum[result[i]]}";

        }
        text.GetComponent<Text>().text = null;
        text.GetComponent<Text>().text += "https://link.clashroyale.com/deck/jp?deck=";
        text.GetComponent<Text>().text += System.String.Join(";", answer);
        text.GetComponent<Text>().text += "&id=22CPYQLLL";

        Debug.Log(text.GetComponent<Text>().text);
    }

    public void OpenUrl()
    {
        Application.OpenURL(text.GetComponent<Text>().text);
    }

    
}

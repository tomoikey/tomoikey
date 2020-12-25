using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;

public class controlor2 : MonoBehaviour
{
    public int pipot; //基準
    const int width = 15; //幅（変更不要）
    const int howMany = 8;
    double fixedWidth; //四角形の横幅
    double harfFixedWidth; //四角形の横幅の半分

    GameObject prefab;
    new GameObject[] gameObject = new GameObject[howMany];
    public GameObject canvas;
    public GameObject scaleClone;
    GameObject pipotObj;
    float pipotObj_localScale_Y;

    bool flag = false; //処理が終わったらtrue

    public List<int> mark = new List<int>(); //高いグループ、低いグループの境目のインデックス番号を格納
    public List<int> memory = new List<int>(); //メモリー
    public int count = 0; //試行回数

    int max; //e - s
    int min = 0; //常に０
    int s; //インデックス番号　先端
    int e; //インデックス番号　終端

    public int memory_added_count = 1; //memoryが書き換えられた回数を記録する

    // Start is called before the first frame update
    void Start()
    {
        GenerateBlocks(howMany);
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
        Set();//ランダムな大きさで配置

        pipot = s + 1;
        pipotObj = gameObject[pipot];
        pipotObj_localScale_Y = pipotObj.transform.localScale.y;

        mark.Add(howMany - 1);
        memory.Add(howMany - 1);
        s = 0;
        e = howMany - 1;
        max = e - s;

        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        max = e - s;

        // s = mark.Count - 1 - memory_added_count;
        //e = memory[0];

        #region デバッグ
        if (Input.GetKey(KeyCode.F1))
        {
            handle(Group(s, e));
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
           
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < gameObject.Length; ++i)
            {
                if (gameObject[i].transform.localScale.y <= pipotObj_localScale_Y)
                {
                    Debug.Log(i);
                    break;
                }
                else continue;
            }

        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < gameObject.Length; ++i)
            {
                Debug.Log(gameObject[i].transform.localScale.y);
            }

        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            
        }
        #endregion
    }

    #region 欠陥なし
    private void Set()
    {
        int gameObjCount;

        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
        gameObjCount = gameObject.Length;
        fixedWidth = (double)(width) / gameObjCount;
        harfFixedWidth = fixedWidth / 2;

        for (int i = 0; i < gameObjCount; ++i)
        {
            float randomScale_y = UnityEngine.Random.Range(0.1f, 9.0f);
            gameObject[i].transform.localScale = new Vector3((float)fixedWidth, randomScale_y, gameObject[i].transform.localScale.z);
            gameObject[i].transform.position = new Vector3(-(float)width * ((float)gameObjCount - 1.0f) / (2.0f * (float)gameObjCount) + i * (float)fixedWidth, -5f, 0f);
        }

    }

    private void Exchange(GameObject a, GameObject b)
    {
        float a_trY = a.transform.localScale.y;
        float b_trY = b.transform.localScale.y;

        a.transform.localScale = new Vector3(a.transform.localScale.x, b_trY, a.transform.localScale.z);
        b.transform.localScale = new Vector3(b.transform.localScale.x, a_trY, b.transform.localScale.z);
    }

    private int DecideMedian() //初回のみ
    {
        int gameObjCount;
        int borderLine;

        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
        gameObjCount = gameObject.Length;

        borderLine = gameObjCount / 2;

        Debug.Log(borderLine);
        return borderLine;
    }

    private void GenerateBlocks(int number)
    {
        for (int i = 0; i < number; ++i)
        {
            prefab = (GameObject)Instantiate(scaleClone);
            prefab.transform.SetParent(canvas.transform, false);
        }
    }

    private GameObject[] Group(int start, int end) //インデックス番号start~endまでの配列
    {
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
        GameObject[] group = new GameObject[end - start + 1];

        for (int i = 0; i < end - start + 1; ++i)
        {
            group[i] = gameObject[start + i];
        }

        return group;
    }

    private void handle(GameObject[] group)
    {
        int high_Num = 0;
        int low_Num = 0;


        for (int i = min; i < group.Length; ++i)
        {
            if (pipotObj.transform.localScale.y >= group[i].transform.localScale.y)//左から基準以下の棒を探す
            {
                low_Num = i;
                break;
            }
        }

        for (int i = max; i > 0; --i)
        {
            if (pipotObj.transform.localScale.y <= group[i].transform.localScale.y)//右から基準以上の棒を探す
            {
                high_Num = i;
                break;
            }
        }

        if (high_Num > low_Num && (high_Num, low_Num) != (0, 0))
        {
            Exchange(group[high_Num], group[low_Num]);

            max = high_Num - 1;
            min = low_Num + 1;
        }
        else
        {
            flag = true;
        }
    }

    private void Chenge_SandE_Value(int s, int e)
    {
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");

        pipot = s + 1;
        pipotObj = gameObject[pipot];
        pipotObj_localScale_Y = pipotObj.transform.localScale.y;
    }
    #endregion

    private void Check()
    {
        if (true)
        {
            GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");

            for(int i = 0; i < gameObject.Length; ++i)
            {
                if (gameObject[i].transform.localScale.y < pipotObj_localScale_Y && i!=gameObject.Length - 1)
                {
                    Chenge_SandE_Value(i, memory[0]); //新しい基準点
                    mark.Add(i);
                    
                    break;
                }
            }

            if (Math.Abs(mark[mark.Count - 1] - memory[0]) <= 2)//整列しなおし
            {
                //markのmemory成分を最後尾に追加する
                mark.Except(memory);
                mark.Union(memory);

                memory = new List<int>();//初期化

                //memoryを上書きする
                for (int mark_last = (mark.Count - 1) - memory_added_count; mark_last <= (mark.Count - 1); ++mark_last)
                {
                    memory.Add(mark[mark_last]);
                }

                memory_added_count++; //memoryの変更回数を＋１する

            }
        }
    }

}

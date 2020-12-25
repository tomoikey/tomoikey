using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class controlor : MonoBehaviour
{
    
    /*
    int pipot; //基準
    const int width = 15; //幅（変更不要）
    const int howMany = 200;
    double fixedWidth; //四角形の横幅
    double harfFixedWidth; //四角形の横幅の半分

    GameObject prefab;
    new GameObject[] gameObject = new GameObject[howMany];
    public GameObject canvas;
    public GameObject scaleClone;
    GameObject pipotObj;

    bool flag = false; //操作が終わっているか


    int high;
    int low;

    */
    // Start is called before the first frame update
    /*
    void Start()
    {
        GenerateBlocks(howMany);
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
        Set();//ランダムな大きさで配置
        pipot = 1;
        pipotObj = gameObject[pipot];

    }

    // Update is called once per frame
    void Update()
    {
        #region デバッグ
        if (Input.GetKey(KeyCode.F1))
        {
            int max = 150;
            int min = 10;
            Go(Group(min, max),min,max);
           
        }

        if (flag && Input.GetKey(KeyCode.F2))
        {
            flag = false; //捜査中に変更


        }
        #endregion

    }

    private void Set()
    {
        int gameObjCount;

        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");
        gameObjCount = gameObject.Length;
        fixedWidth = (double)(width) / gameObjCount;
        harfFixedWidth = fixedWidth / 2;

        for (int i = 0; i < gameObjCount; ++i)
        {
            float randomScale_y = Random.Range(0.1f, 9.0f);
            gameObject[i].transform.localScale = new Vector3((float)fixedWidth, randomScale_y, gameObject[i].transform.localScale.z);
            gameObject[i].transform.position = new Vector3(-(float)width * ((float)gameObjCount - 1.0f) / (2.0f * (float)gameObjCount) + i * (float)fixedWidth, -5f, 0f);
        }

    }

    private void Exchange(GameObject a, GameObject b)
    {
        Vector3 a_pos = a.transform.position;
        Vector3 b_pos = b.transform.position;

        a.transform.position = b_pos;
        b.transform.position = a_pos;
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
    */
    
   
    
    //private (int,int) Handle(GameObject[] objects,int min /*左端*/ ,int max /*右端*/ )
    /*{
        
            GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");

            int high_Num = 0;
            int low_Num = 0;

            for (int i = min; i < objects.Length; ++i)
            {
                if (pipotObj.transform.localScale.y >= objects[i].transform.localScale.y)//左から基準以下の棒を探す
                {
                    low_Num = i;
                    //Debug.Log("基準より低いのは" + low_Num + "番目です"+ "長さ" + gameObject[high_Num].transform.localScale.y);
                    break;
                }
            }

            for (int i = max; i > 0; --i)
            {
                if (pipotObj.transform.localScale.y <= objects[i].transform.localScale.y)//右から基準以上の棒を探す
                {
                    high_Num = i;
                    //Debug.Log("基準より高いのは" + high_Num + "番目です"+ "長さ"+gameObject[low_Num].transform.localScale.y);
                    break;
                }
            }

            return (high_Num, low_Num);

    }
    
    private void GenerateBlocks(int number)
    {
        for(int i = 0; i < number; ++i)
        {
            prefab = (GameObject)Instantiate(scaleClone);
            prefab.transform.SetParent(canvas.transform, false);
        }
    }

    private void Go(GameObject[] objects,int min,int max) //基準を元に大きいグループと小さいグループに分けるメソッド
    {   
        (high, low) = Handle(objects,min, max);

        if (!flag && high > low && (high, low) != (0, 0))
        {
            Exchange(objects[high], objects[low]);

            max = (high, low).high - 1;
            min = (high, low).low + 1;
        }
        else
        {
            flag = true;
        }
        
    }

    private GameObject[] Group(int start,int end) //始まりと終わりを指定して配列化する
    {
        GameObject[] group = new GameObject[end - start];
        GameObject[] gameObject = GameObject.FindGameObjectsWithTag("cube");

        for(int i = 0; i < group.Length; ++i)
        {
            group[i] = gameObject[start + i];
        }

        return group;
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    //int型の変数mpを宣言し、53で初期化
    private int mp = 53;

    //魔法攻撃用の関数
    public void Magic()
    {
            if (mp >= 5)
            {
                this.mp -= 5;

                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }

            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
    }
}


public class TestB : MonoBehaviour
{
    void Start ()
    {
        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

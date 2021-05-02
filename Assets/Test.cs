using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列の初期化
        int[] array = { 50, 30, 80, 100, 20 };

        //配列の各要素を順番に表示させる
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素を逆順に表示させる
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

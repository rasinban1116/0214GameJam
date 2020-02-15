using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGeneSprict : MonoBehaviour
{
    public GameObject Bomb; // 生成するオブジェクト
    public float BornTime; // 生成する間隔

    private float NowTime; // 現在の時間

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            float BornX = Random.Range(-8.0f, 8.0f);
            float BornY = Random.Range(-4.5f, 4.5f);
            Instantiate(Bomb, new Vector3(BornX, BornY, 0.0f), Quaternion.identity);
        }

        NowTime = BornTime;
    }

    // Update is called once per frame
    void Update()
    {
        // タイマー処理
        NowTime -= Time.deltaTime;

        // 0秒になったらスポーンして0.5減らす
        if(NowTime < 0.0f)
        {
            float BornX = Random.Range(-8.0f, 8.0f);
            float BornY = Random.Range(-4.5f, 4.5f);
            Instantiate(Bomb, new Vector3(BornX, BornY, 0.0f), Quaternion.identity);
            if(BornTime > 2.0f)
            {
                BornTime -= 0.5f;
            }
            NowTime = BornTime;
        }

    }
}

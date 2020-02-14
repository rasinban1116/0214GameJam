using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTimer : MonoBehaviour
{
    public Text timerText;

    //合計時間
    public float totalTime;
    //表示用の時間データ
    int second;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime >= 0)
        {
            totalTime -= Time.deltaTime;
            second = (int)totalTime;
            timerText.text = second.ToString();
        }
        if (totalTime < 0)
        {
            timerText.text = "スタート".ToString();
        }
    }
}

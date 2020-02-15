using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public float WorkSpeed = 0.3f;
    private Vector3 PlayerScale;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        var time = Time.deltaTime;
        var LH = Input.GetAxis("Player2Horizontal");
        var LV = Input.GetAxis("Player2Vertical");

        if (LH != 0 || LV != 0)
        {
            var pos = transform.position;
            pos.x = WorkSpeed * time * LH;
            pos.y = WorkSpeed * time * LV;
            transform.position += pos;
        }

    }
}

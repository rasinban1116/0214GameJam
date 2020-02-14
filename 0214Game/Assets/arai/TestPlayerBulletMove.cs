using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerBulletMove : MonoBehaviour
{
    private float Movex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:0214Game/Assets/mori/PlayerStatus.cs
        //test
=======

        Transform mytransform = this.transform;
        Vector3 Pos = transform.position;
        Pos.x += 0.01f;

        mytransform.position = Pos;
>>>>>>> master:0214Game/Assets/arai/TestPlayerBulletMove.cs

    }
}

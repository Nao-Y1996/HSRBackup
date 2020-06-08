using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSR1_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello Unity");
}

    // Update is called once per frame
    void Update()
    {

        float rot = Input.GetAxisRaw("Horizontal");//← →矢印
        float trans = -Input.GetAxisRaw("Vertical");//↑ ↓矢印
        // transformを取得
        Transform myTransform = this.transform;

        if (rot == 1)
        {
            // ローカル座標基準で、現在の回転量へ加算する
            myTransform.Rotate(new Vector3(0.0f, 0.0f, 1.0f));
        }
        if (rot == -1)
        {
            // ローカル座標基準で、現在の回転量へ加算する
            transform.Rotate(new Vector3(0.0f, 0.0f, -1.0f));
        }
        if (trans == 1)
        {
            // ローカル座標基準で、現在の位置へ加算する
            myTransform.Translate(0.01f, 0.0f, 0.0f);
        }
        if (trans == -1)
        {
            // ローカル座標基準で、現在の位置へ加算する
            myTransform.Translate(-0.01f, 0.0f, 0.0f);
        }
        Debug.Log("trans : " + myTransform.localPosition);
    }
}

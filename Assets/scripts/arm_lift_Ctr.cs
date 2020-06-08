using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arm_lift_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        //スライダーの値を取得
        Slider ArmLiftSlider;
        ArmLiftSlider = GetComponent<Slider>();
        ArmLiftSlider.maxValue = 0.69f;
        float x = ArmLiftSlider.value;

        //TorsoLiftLinkのlocalPositionの取得
        GameObject TorsoLink = GameObject.FindGameObjectWithTag("TorsoLiftLink");
        Transform TorsoLink_tf = TorsoLink.GetComponent<Transform>();
        Vector3 TorsoLink_pos = TorsoLink_tf.localPosition;

        //ArmLiftLinkのlocalpositionの取得
        GameObject ArmLiftLink = GameObject.FindGameObjectWithTag("ArmLift");
        Transform ArmLiftLink_tf = ArmLiftLink.GetComponent<Transform>();
        Vector3 ArmLiftLink_pos = ArmLiftLink_tf.localPosition;

        //各Linkの位置の変更
        TorsoLink_pos = new Vector3(0, 0, ArmLift(x)/2.0f + 0.752f);
        ArmLiftLink_pos = new Vector3(0, 0, ArmLift(x) + 0.34f);
        ArmLiftLink_tf.localPosition = ArmLiftLink_pos;
        TorsoLink_tf.localPosition = TorsoLink_pos;

        //transform.Translate(0, 0, 0.01f);
        Debug.Log("ArmLiftLink_pos : " + ArmLiftLink_pos);
        Debug.Log("-----------------");

    }


    static float ArmLift(float x) // 関数定義
    {
      
        return x;
    }

}

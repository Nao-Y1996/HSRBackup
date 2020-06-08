using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hand_motor_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スライダーの値を取得
        GameObject sliderobj = GameObject.FindGameObjectWithTag("HandMotor");
        Slider HandMotorSlider;
        HandMotorSlider = sliderobj.GetComponent<Slider>();
        HandMotorSlider.maxValue = 71.0f;
        HandMotorSlider.minValue = -6.0f;
        float x = HandMotorSlider.value;

        //各LinkのlocalEulerAnglesの取得
        GameObject HandL_Link = GameObject.FindGameObjectWithTag("HandLProximalLink");
        Transform HandL_Link_tf = HandL_Link.GetComponent<Transform>();
        Vector3 HandL_Link_rot = HandL_Link_tf.localEulerAngles;

        GameObject HandR_Link = GameObject.FindGameObjectWithTag("HandRProximalLink");
        Transform HandR_Link_tf = HandR_Link.GetComponent<Transform>();
        Vector3 HandR_Link_rot = HandR_Link_tf.localEulerAngles;



        //各Linkの角度の変更
        HandR_Link_rot = new Vector3(-x, 0, 0);
        HandL_Link_rot = new Vector3(x, 0, 0);
        HandR_Link_tf.localEulerAngles = HandR_Link_rot;
        HandL_Link_tf.localEulerAngles = HandL_Link_rot;
    }
}

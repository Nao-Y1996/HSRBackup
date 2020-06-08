using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrist_roll_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sliderobj = GameObject.FindGameObjectWithTag("WristRoll");
        Slider WristRollSlider;
        WristRollSlider = sliderobj.GetComponent<Slider>();
        WristRollSlider.maxValue = 210.0f;
        WristRollSlider.minValue = -110.0f;
        float z = WristRollSlider.value;


        //ArmFlexLinkのlocalpositionの取得
        Vector3 wristrollLink_rot = transform.localEulerAngles;

        //各Linkの位置の変更
        wristrollLink_rot = new Vector3(0, 0, z);
        transform.localEulerAngles = wristrollLink_rot;

        //transform.Translate(0, 0, 0.01f) ;
        //Debug.Log(wristrollLink_rot);
        //Debug.Log("-----------------");
    }
}

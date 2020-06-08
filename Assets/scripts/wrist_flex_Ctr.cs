using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrist_flex_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sliderobj = GameObject.FindGameObjectWithTag("WristFlex");
        Slider WristFlexSlider;
        WristFlexSlider = sliderobj.GetComponent<Slider>();
        WristFlexSlider.maxValue = 70.0f;
        WristFlexSlider.minValue = -110.0f;
        float y = WristFlexSlider.value;
        y = -90.0f;
        WristFlexSlider.value = y;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sliderobj = GameObject.FindGameObjectWithTag("WristFlex");
        Slider WristFlexSlider;
        WristFlexSlider = sliderobj.GetComponent<Slider>();
        WristFlexSlider.maxValue = 70.0f;
        WristFlexSlider.minValue = -110.0f;
        float y = WristFlexSlider.value;


        //ArmFlexLinkのlocalpositionの取得
        Vector3 wristflexLink_rot = transform.localEulerAngles;

        //各Linkの位置の変更
        wristflexLink_rot = new Vector3(0, y, 0);
        transform.localEulerAngles = wristflexLink_rot;

        //transform.Translate(0, 0, 0.01f) ;
        //Debug.Log(wristflexLink_rot);
        //Debug.Log("-----------------");
    }
}

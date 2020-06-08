using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arm_flex_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sliderobj = GameObject.FindGameObjectWithTag("ArmFlex");
        Slider ArmFlexSlider;
        ArmFlexSlider = sliderobj.GetComponent<Slider>();
        ArmFlexSlider.maxValue = 0.0f;
        ArmFlexSlider.minValue = -150.0f;
        float y = ArmFlexSlider.value;


        //ArmFlexLinkのlocalpositionの取得
        Vector3 armflexLink_rot = transform.localEulerAngles;

        //各Linkの位置の変更
        armflexLink_rot = new Vector3(0, y, 0);
        transform.localEulerAngles = armflexLink_rot;

        //transform.Translate(0, 0, 0.01f) ;
        //Debug.Log(armflexLink_rot);
        //Debug.Log("-----------------");
    }
}

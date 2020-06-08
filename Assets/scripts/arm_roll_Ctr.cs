using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arm_roll_Ctr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sliderobj = GameObject.FindGameObjectWithTag("ArmRoll");
        Slider ArmRollSlider;
        ArmRollSlider = sliderobj.GetComponent<Slider>();
        ArmRollSlider.maxValue = 210.0f;
        ArmRollSlider.minValue = -110.0f;
        float z = ArmRollSlider.value;


        //ArmFlexLinkのlocalpositionの取得
        Vector3 armrollLink_rot = transform.localEulerAngles;

        //各Linkの位置の変更
        armrollLink_rot = new Vector3(0, 0, z);
        transform.localEulerAngles = armrollLink_rot;

        //transform.Translate(0, 0, 0.01f) ;
        //Debug.Log(armrollLink_rot);
        //Debug.Log("-----------------");
    }
}

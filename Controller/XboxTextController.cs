using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XboxTextController : MonoBehaviour
{
    public TextMesh text;

    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            //Debug.Log("button0");
            text.text = "A Button";
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            //Debug.Log("button1");
            text.text = "B button";
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            //Debug.Log("button2");
            text.text = "X button";
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            //Debug.Log("button3");
            text.text = "Y button";
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            //Debug.Log("button4");
            text.text = "XB1LeftShoulder";
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            //Debug.Log("button5");
            text.text = "XB1RightShoulder";
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            //Debug.Log("button6");
            text.text = "XB1View";
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            //Debug.Log("button7");
            text.text = "XB1Menu";
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            //Debug.Log("button8");
            text.text = "LStick押し込み";
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            //Debug.Log("button9");
            text.text = "RStick押し込み";
        }

        //以下からはパラメータ未調整
        //float lsh = Input.GetAxis("L_Stick_H");
        //float lsv = Input.GetAxis("L_Stick_V");
        //if ((lsh != 0) || (lsv != 0))
        //{
            //Debug.Log("L stick:" + lsh + "," + lsv);
        //}
        //R Stick
        //float rsh = Input.GetAxis("R_Stick_H");
        //float rsv = Input.GetAxis("R_Stick_V");
        //if ((rsh != 0) || (rsv != 0))
        //{
            //Debug.Log("R stick:" + rsh + "," + rsv);
        //}
        //D-Pad
        //float dph = Input.GetAxis("D_Pad_H");
        //float dpv = Input.GetAxis("D_Pad_V");
        //if ((dph != 0) || (dpv != 0))
        //{
            //Debug.Log("D Pad:" + dph + "," + dpv);
        //}
        //Trigger
        //float tri = Input.GetAxis("L_R_Trigger");
        //if (tri > 0)
        //{
            //Debug.Log("L trigger:" + tri);
        //}
        //else if (tri < 0)
        //{
            //Debug.Log("R trigger:" + tri);
        //}
        //else
        //{
            //Debug.Log("  trigger:none");
        //}
    }
}
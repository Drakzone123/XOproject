using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Windowanimetion : MainSystem
{
    [SerializeField] GameObject setting_Window;
    [SerializeField] GameObject sound_Window;
    [SerializeField] GameObject opption_Window;
    [SerializeField] GameObject main_Window;
    
    

    public void Start()
    {
        sound_Window.transform.localPosition = new Vector2(100, 0);
        opption_Window.transform.localPosition = new Vector2(0, -1100);
    }
    public void Setting_Tween()
    {
        setting_Window.LeanMoveLocalY(40, 1);
    }
    public void B_Setting_Tween()
    {
        setting_Window.LeanMoveLocalY(0, 1);
    }

    //*-------------------------------------*//

    public void Soundset_Tween()
    {
        sound_Window.LeanMoveLocalX(0, 1);
        setting_Window.transform.localPosition = new Vector2(-100, 0);
    }
    public void B_Soundset_Tween()
    {
        sound_Window.LeanMoveLocalX(100, 1);
        setting_Window.LeanMoveLocalX(0, 1);
    }
    /*--------------------------------------*/

    public void Opption_tween()
    {
        opption_Window.LeanMoveLocalY(0, 1);
        main_Window.transform.localPosition = new Vector2(0, 1100);
    }
    public void B_Opption_tween()
    {
        main_Window.LeanMoveLocalY(0, 1);
        opption_Window.transform.localPosition = new Vector2(0, -1100);
    }
    /*-------------------------------------*/
    public void Select_Tween(GameObject button_Select)
    {
        button_Select.LeanScale(new Vector2(1.2f,1.2f), 0.2f);
    }
    public void U_Select_Tween(GameObject button_Select)
    {
        button_Select.LeanScale(new Vector2(1f, 1f), 0.2f);
    }

    /*--------------------------------------*/

   

}

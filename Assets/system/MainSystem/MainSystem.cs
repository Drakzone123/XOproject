using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSystem : MonoBehaviour
{
    [Header("variable for turncheck , value")]
    [SerializeField] public GameObject[] turn_Active;
    [SerializeField] public static int turn_Check = 1;
    [SerializeField] public static int skill_Turn = 1;
    [SerializeField] public static int xo_Check;
    [SerializeField] public static int count_Number;
    [SerializeField] public static int x_Point;
    [SerializeField] public static int o_Point;
    [SerializeField] public static int t_Point;
    [SerializeField] public static int X_Turn;
    [SerializeField] public static int O_Turn;


    [Header("variable for Skill System")]
    [SerializeField] public GameObject[] X_skill;
    [SerializeField] public GameObject[] O_skill;
    [SerializeField] public GameObject[] X_skillUsed;
    [SerializeField] public GameObject[] O_skillUsed;
    [SerializeField] public GameObject[] X_Space;
    [SerializeField] public GameObject[] O_Space;
    [SerializeField] public GameObject[] X_Skillcontrol;
    [SerializeField] public GameObject[] O_Skillcontrol;
    [SerializeField] public GameObject[] X_cooldown_Area;
    [SerializeField] public GameObject[] O_cooldown_Area;
    [SerializeField] public GameObject X_Usebutton;
    [SerializeField] public GameObject O_Usebutton;
    [SerializeField] public GameObject X_Canclebutton;
    [SerializeField] public GameObject O_Canclebutton;
    [SerializeField] public static int skill_cooldown;
    [SerializeField] public static int X_skillPoint;
    [SerializeField] public static int O_skillPoint;
    [SerializeField] public static int Xskill_Count = 3;
    [SerializeField] public static int Oskill_Count = 3;
    [SerializeField] public static int[] Xskill_CheckActive = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    [SerializeField] public static int[] Oskill_CheckActive = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



    [Header("variable for Button only")]
    public GameObject[] canvas_Ative;



    [Header("variable for obj")]
    public GameObject X;
    public GameObject O;
    public GameObject Box;
    public GameObject X_Cha;
    public GameObject O_Cha;


    [Header("variable for Win check")]
    [SerializeField] public GameObject[] WX;
    [SerializeField] public GameObject[] WO;
    [SerializeField] public GameObject x_Winscene;
    [SerializeField] public GameObject o_Winscene;

    [Header("variable for Setting menu")]
    [SerializeField] public GameObject[] grid_G;
    [SerializeField] public GameObject settint_scene;
    [SerializeField] public GameObject[] option;
    [SerializeField] public GameObject[] game_scene;

    [Header("variable for HP System")]
    [SerializeField] public Slider x_HP;
    [SerializeField] public Slider o_HP;
    [SerializeField] public static int x_Damage = 25;
    [SerializeField] public static int o_Damage = 25;

    


    public void XO_Count()
    {
        count_Number++;

        if (count_Number % 2 != 0)
        {
            X_Turn++;
            X.SetActive(true);

        }
        if (count_Number % 2 == 0)
        {
            O_Turn++;
            O.SetActive(true);

        }
        Box.SetActive(false);

    }
    public void Turn_Count()
    {
        if (count_Number % 2 == 0)
        {
            turn_Check++;
            skill_Turn++;

        }




    }
    public void Skill_count()
    {
        if (skill_Turn % 3 == 0 && skill_Turn != 0)
        {
            X_skillPoint++;
            O_skillPoint++;
            skill_Turn = 0;


        }
        if (X_skillPoint >= Xskill_Count) X_skillPoint = Xskill_Count;
        if (O_skillPoint >= Oskill_Count) O_skillPoint = Oskill_Count;



    }
    public void Skill_Active()
    {
        /*------------------------------ Xskillpoint ---------------------*/
        if (X_skillPoint == 0)
        {
            X_skill[0].SetActive(false);
            X_skill[1].SetActive(false);
            X_skill[2].SetActive(false);
            X_Usebutton.SetActive(false);
        }
        if (X_skillPoint == 1)
        {
            X_skill[0].SetActive(true);
            X_skill[1].SetActive(false);
            X_skill[2].SetActive(false);
        }
        if (X_skillPoint == 2)
        {
            X_skill[0].SetActive(true);
            X_skill[1].SetActive(true);
            X_skill[2].SetActive(false);
        }
        if (X_skillPoint == 3)
        {
            X_skill[0].SetActive(true);
            X_skill[1].SetActive(true);
            X_skill[2].SetActive(true);
        }
        /*------------------------------ Oskillpoint ---------------------*/

        if (O_skillPoint == 0)
        {
            O_skill[0].SetActive(false);
            O_skill[1].SetActive(false);
            O_skill[2].SetActive(false);
            O_Usebutton.SetActive(false);
        }
        if (O_skillPoint == 1)
        {
            O_skill[0].SetActive(true);
            O_skill[1].SetActive(false);
            O_skill[2].SetActive(false);
        }
        if (O_skillPoint == 2)
        {
            O_skill[0].SetActive(true);
            O_skill[1].SetActive(true);
            O_skill[2].SetActive(false);
        }
        if (O_skillPoint == 3)
        {
            O_skill[0].SetActive(true);
            O_skill[1].SetActive(true);
            O_skill[2].SetActive(true);
        }
        /*------------------------------ XskillUsed ---------------------*/

        if (Xskill_Count == 0)
        {
            X_skillUsed[0].SetActive(false);
            X_skillUsed[1].SetActive(false);
            X_skillUsed[2].SetActive(false);
            X_Usebutton.SetActive(false);
        }
        if (Xskill_Count == 1)
        {
            X_skillUsed[0].SetActive(true);
            X_skillUsed[1].SetActive(false);
            X_skillUsed[2].SetActive(false);
        }
        if (Xskill_Count == 2)
        {
            X_skillUsed[0].SetActive(true);
            X_skillUsed[1].SetActive(true);
            X_skillUsed[2].SetActive(false);
        }
        if (Xskill_Count == 3)
        {
            X_skillUsed[0].SetActive(true);
            X_skillUsed[1].SetActive(true);
            X_skillUsed[2].SetActive(true);
        }
        /*------------------------------ OskillUsed ---------------------*/
        if (Oskill_Count == 0)
        {
            O_skillUsed[0].SetActive(false);
            O_skillUsed[1].SetActive(false);
            O_skillUsed[2].SetActive(false);
            O_Usebutton.SetActive(false);
        }
        if (Oskill_Count == 1)
        {
            O_skillUsed[0].SetActive(true);
            O_skillUsed[1].SetActive(false);
            O_skillUsed[2].SetActive(false);
        }
        if (Oskill_Count == 2)
        {
            O_skillUsed[0].SetActive(true);
            O_skillUsed[1].SetActive(true);
            O_skillUsed[2].SetActive(false);
        }
        if (Oskill_Count == 3)
        {
            O_skillUsed[0].SetActive(true);
            O_skillUsed[1].SetActive(true);
            O_skillUsed[2].SetActive(true);
        }

        /*------------------------------ skill_Usingbutton ---------------------*/


        if (X_skillPoint > 0)
        {
            if (count_Number % 2 == 0)
            {
                X_Usebutton.SetActive(true);
            }
            else { X_Usebutton.SetActive(false); }

        }

        if (O_skillPoint > 0)
        {
            if (count_Number % 2 != 0)
            {
                O_Usebutton.SetActive(true);
            }
            else { O_Usebutton.SetActive(false); }
        }


    }
    public void Turn_Active()
    {

        if (count_Number % 2 != 0)
        {
            turn_Active[0].SetActive(true);
            turn_Active[1].SetActive(false);
            X_Cha.SetActive(true);
            O_Cha.SetActive(false);

        }
        if (count_Number % 2 == 0)
        {
            turn_Active[1].SetActive(true);
            turn_Active[0].SetActive(false);
            O_Cha.SetActive(true);
            X_Cha.SetActive(false);

        }



    }
    public void XSkill_Use()
    {

        X_skillPoint--;
        Xskill_Count--;
        X_Affectskillspace();
        X_Usebutton.SetActive(false);
        X_Canclebutton.SetActive(true);

    }
    public void OSkill_Use()
    {

        O_skillPoint--;
        Oskill_Count--;
        O_Usebutton.SetActive(false);
        O_Canclebutton.SetActive(true);
        O_Affectskillspace();


    }
    public void XSkill_Cancle()
    {
        X_skillPoint++;
        Xskill_Count++;
        for (int X_AcspaceNum = 0; X_AcspaceNum < 25; X_AcspaceNum++)
        {
            X_Space[X_AcspaceNum].SetActive(false);
        }
        X_Usebutton.SetActive(true);
        X_Canclebutton.SetActive(false);
    }
    public void OSkill_Cancle()
    {
        O_skillPoint++;
        Oskill_Count++;
        for (int O_AcspaceNum = 0; O_AcspaceNum < 25; O_AcspaceNum++)
        {
            O_Space[O_AcspaceNum].SetActive(false);
        }
        O_Usebutton.SetActive(true);
        O_Canclebutton.SetActive(false);
    }
    public void Skill_Destroy()
    {
        count_Number++;
        if (X.activeSelf == true)
        {
            X.SetActive(false);

        }
        if (O.activeSelf == true)
        {
            O.SetActive(false);
        }

        if (count_Number % 2 != 0)
        {


            X_Turn++;
        }
        if (count_Number % 2 == 0)
        {


            O_Turn++;
        }
        Box.SetActive(true);
        X_Canclebutton.SetActive(false);
        O_Canclebutton.SetActive(false);


    }
    public void X_Affectskillspace()
    {
        if (O_Skillcontrol[0].activeSelf == true)
        {
            X_Space[0].SetActive(true);
        }
        if (O_Skillcontrol[1].activeSelf == true)
        {
            X_Space[1].SetActive(true);
        }
        if (O_Skillcontrol[2].activeSelf == true)
        {
            X_Space[2].SetActive(true);
        }
        if (O_Skillcontrol[3].activeSelf == true)
        {
            X_Space[3].SetActive(true);
        }
        if (O_Skillcontrol[4].activeSelf == true)
        {
            X_Space[4].SetActive(true);
        }
        if (O_Skillcontrol[5].activeSelf == true)
        {
            X_Space[5].SetActive(true);
        }
        if (O_Skillcontrol[6].activeSelf == true)
        {
            X_Space[6].SetActive(true);
        }
        if (O_Skillcontrol[7].activeSelf == true)
        {
            X_Space[7].SetActive(true);
        }
        if (O_Skillcontrol[8].activeSelf == true)
        {
            X_Space[8].SetActive(true);
        }
        if (O_Skillcontrol[9].activeSelf == true)
        {
            X_Space[9].SetActive(true);
        }
        if (O_Skillcontrol[10].activeSelf == true)
        {
            X_Space[10].SetActive(true);
        }
        if (O_Skillcontrol[11].activeSelf == true)
        {
            X_Space[11].SetActive(true);
        }
        if (O_Skillcontrol[12].activeSelf == true)
        {
            X_Space[12].SetActive(true);
        }
        if (O_Skillcontrol[13].activeSelf == true)
        {
            X_Space[13].SetActive(true);
        }
        if (O_Skillcontrol[14].activeSelf == true)
        {
            X_Space[14].SetActive(true);
        }
        if (O_Skillcontrol[15].activeSelf == true)
        {
            X_Space[15].SetActive(true);
        }
        if (O_Skillcontrol[16].activeSelf == true)
        {
            X_Space[16].SetActive(true);
        }
        if (O_Skillcontrol[17].activeSelf == true)
        {
            X_Space[17].SetActive(true);
        }
        if (O_Skillcontrol[18].activeSelf == true)
        {
            X_Space[18].SetActive(true);
        }
        if (O_Skillcontrol[19].activeSelf == true)
        {
            X_Space[19].SetActive(true);
        }
        if (O_Skillcontrol[20].activeSelf == true)
        {
            X_Space[20].SetActive(true);
        }
        if (O_Skillcontrol[21].activeSelf == true)
        {
            X_Space[21].SetActive(true);
        }
        if (O_Skillcontrol[22].activeSelf == true)
        {
            X_Space[22].SetActive(true);
        }
        if (O_Skillcontrol[23].activeSelf == true)
        {
            X_Space[23].SetActive(true);
        }
        if (O_Skillcontrol[24].activeSelf == true)
        {
            X_Space[24].SetActive(true);
        }
    }
    public void O_Affectskillspace()
    {
        if (X_Skillcontrol[0].activeSelf == true)
        {
            O_Space[0].SetActive(true);
        }
        if (X_Skillcontrol[1].activeSelf == true)
        {
            O_Space[1].SetActive(true);
        }
        if (X_Skillcontrol[2].activeSelf == true)
        {
            O_Space[2].SetActive(true);
        }
        if (X_Skillcontrol[3].activeSelf == true)
        {
            O_Space[3].SetActive(true);
        }
        if (X_Skillcontrol[4].activeSelf == true)
        {
            O_Space[4].SetActive(true);
        }
        if (X_Skillcontrol[5].activeSelf == true)
        {
            O_Space[5].SetActive(true);
        }
        if (X_Skillcontrol[6].activeSelf == true)
        {
            O_Space[6].SetActive(true);
        }
        if (X_Skillcontrol[7].activeSelf == true)
        {
            O_Space[7].SetActive(true);
        }
        if (X_Skillcontrol[8].activeSelf == true)
        {
            O_Space[8].SetActive(true);
        }
        if (X_Skillcontrol[9].activeSelf == true)
        {
            O_Space[9].SetActive(true);
        }
        if (X_Skillcontrol[10].activeSelf == true)
        {
            O_Space[10].SetActive(true);
        }
        if (X_Skillcontrol[11].activeSelf == true)
        {
            O_Space[11].SetActive(true);
        }
        if (X_Skillcontrol[12].activeSelf == true)
        {
            O_Space[12].SetActive(true);
        }
        if (X_Skillcontrol[13].activeSelf == true)
        {
            O_Space[13].SetActive(true);
        }
        if (X_Skillcontrol[14].activeSelf == true)
        {
            O_Space[14].SetActive(true);
        }
        if (X_Skillcontrol[15].activeSelf == true)
        {
            O_Space[15].SetActive(true);
        }
        if (X_Skillcontrol[16].activeSelf == true)
        {
            O_Space[16].SetActive(true);
        }
        if (X_Skillcontrol[17].activeSelf == true)
        {
            O_Space[17].SetActive(true);
        }
        if (X_Skillcontrol[18].activeSelf == true)
        {
            O_Space[18].SetActive(true);
        }
        if (X_Skillcontrol[19].activeSelf == true)
        {
            O_Space[19].SetActive(true);
        }
        if (X_Skillcontrol[20].activeSelf == true)
        {
            O_Space[20].SetActive(true);
        }
        if (X_Skillcontrol[21].activeSelf == true)
        {
            O_Space[21].SetActive(true);
        }
        if (X_Skillcontrol[22].activeSelf == true)
        {
            O_Space[22].SetActive(true);
        }
        if (X_Skillcontrol[23].activeSelf == true)
        {
            O_Space[23].SetActive(true);
        }
        if (X_Skillcontrol[24].activeSelf == true)
        {
            O_Space[24].SetActive(true);
        }
    }
    public void Skill_regrid()
    {
        //----X_Regrid-----//
        X_Space[0].SetActive(false);
        X_Space[1].SetActive(false);
        X_Space[2].SetActive(false);
        X_Space[3].SetActive(false);
        X_Space[4].SetActive(false);
        X_Space[5].SetActive(false);
        X_Space[6].SetActive(false);
        X_Space[7].SetActive(false);
        X_Space[8].SetActive(false);
        X_Space[9].SetActive(false);
        X_Space[10].SetActive(false);
        X_Space[11].SetActive(false);
        X_Space[12].SetActive(false);
        X_Space[13].SetActive(false);
        X_Space[14].SetActive(false);
        X_Space[15].SetActive(false);
        X_Space[16].SetActive(false);
        X_Space[17].SetActive(false);
        X_Space[18].SetActive(false);
        X_Space[19].SetActive(false);
        X_Space[20].SetActive(false);
        X_Space[21].SetActive(false);
        X_Space[22].SetActive(false);
        X_Space[23].SetActive(false);
        X_Space[24].SetActive(false);
        //----O_Regrid-----//
        O_Space[0].SetActive(false);
        O_Space[1].SetActive(false);
        O_Space[2].SetActive(false);
        O_Space[3].SetActive(false);
        O_Space[4].SetActive(false);
        O_Space[5].SetActive(false);
        O_Space[6].SetActive(false);
        O_Space[7].SetActive(false);
        O_Space[8].SetActive(false);
        O_Space[9].SetActive(false);
        O_Space[10].SetActive(false);
        O_Space[11].SetActive(false);
        O_Space[12].SetActive(false);
        O_Space[13].SetActive(false);
        O_Space[14].SetActive(false);
        O_Space[15].SetActive(false);
        O_Space[16].SetActive(false);
        O_Space[17].SetActive(false);
        O_Space[18].SetActive(false);
        O_Space[19].SetActive(false);
        O_Space[20].SetActive(false);
        O_Space[21].SetActive(false);
        O_Space[22].SetActive(false);
        O_Space[23].SetActive(false);
        O_Space[24].SetActive(false);
    }
    public void XSkill_CooldownArea(Button XcooldownArea)
    {
        if (XcooldownArea.name == ("A1_Xskillarea"))
        {
            Xskill_CheckActive[0] = 2;
            if (Xskill_CheckActive[0] == 2) X_cooldown_Area[0].SetActive(true);
        }
        if (XcooldownArea.name == ("A2_Xskillarea"))
        {
            Xskill_CheckActive[1] = 2;
            if (Xskill_CheckActive[1] == 2) X_cooldown_Area[1].SetActive(true);
        }
        if (XcooldownArea.name == ("A3_Xskillarea"))
        {
            Xskill_CheckActive[2] = 2;
            if (Xskill_CheckActive[2] == 2) X_cooldown_Area[2].SetActive(true);
        }
        if (XcooldownArea.name == ("A4_Xskillarea"))
        {
            Xskill_CheckActive[3] = 2;
            if (Xskill_CheckActive[3] == 2) X_cooldown_Area[3].SetActive(true);
        }
        if (XcooldownArea.name == ("A5_Xskillarea"))
        {
            Xskill_CheckActive[4] = 2;
            if (Xskill_CheckActive[4] == 2) X_cooldown_Area[4].SetActive(true);
        }
        if (XcooldownArea.name == ("B1_Xskillarea"))
        {
            Xskill_CheckActive[5] = 2;
            if (Xskill_CheckActive[5] == 2) X_cooldown_Area[5].SetActive(true);
        }
        if (XcooldownArea.name == ("B2_Xskillarea"))
        {
            Xskill_CheckActive[6] = 2;
            if (Xskill_CheckActive[6] == 2) X_cooldown_Area[6].SetActive(true);
        }
        if (XcooldownArea.name == ("B3_Xskillarea"))
        {
            Xskill_CheckActive[7] = 2;
            if (Xskill_CheckActive[7] == 2) X_cooldown_Area[7].SetActive(true);
        }
        if (XcooldownArea.name == ("B4_Xskillarea"))
        {
            Xskill_CheckActive[8] = 2;
            if (Xskill_CheckActive[8] == 2) X_cooldown_Area[8].SetActive(true);
        }
        if (XcooldownArea.name == ("B5_Xskillarea"))
        {
            Xskill_CheckActive[9] = 2;
            if (Xskill_CheckActive[9] == 2) X_cooldown_Area[9].SetActive(true);
        }
        if (XcooldownArea.name == ("C1_Xskillarea"))
        {
            Xskill_CheckActive[10] = 2;
            if (Xskill_CheckActive[10] == 2) X_cooldown_Area[10].SetActive(true);
        }
        if (XcooldownArea.name == ("C2_Xskillarea"))
        {
            Xskill_CheckActive[11] = 2;
            if (Xskill_CheckActive[11] == 2) X_cooldown_Area[11].SetActive(true);
        }
        if (XcooldownArea.name == ("C3_Xskillarea"))
        {
            Xskill_CheckActive[12] = 2;
            if (Xskill_CheckActive[12] == 2) X_cooldown_Area[12].SetActive(true);
        }
        if (XcooldownArea.name == ("C4_Xskillarea"))
        {
            Xskill_CheckActive[13] = 2;
            if (Xskill_CheckActive[13] == 2) X_cooldown_Area[13].SetActive(true);
        }
        if (XcooldownArea.name == ("C5_Xskillarea"))
        {
            Xskill_CheckActive[14] = 2;
            if (Xskill_CheckActive[14] == 2) X_cooldown_Area[14].SetActive(true);
        }
        if (XcooldownArea.name == ("D1_Xskillarea"))
        {
            Xskill_CheckActive[15] = 2;
            if (Xskill_CheckActive[15] == 2) X_cooldown_Area[15].SetActive(true);
        }
        if (XcooldownArea.name == ("D2_Xskillarea"))
        {
            Xskill_CheckActive[16] = 2;
            if (Xskill_CheckActive[16] == 2) X_cooldown_Area[16].SetActive(true);
        }
        if (XcooldownArea.name == ("D3_Xskillarea"))
        {
            Xskill_CheckActive[17] = 2;
            if (Xskill_CheckActive[17] == 2) X_cooldown_Area[17].SetActive(true);
        }
        if (XcooldownArea.name == ("D4_Xskillarea"))
        {
            Xskill_CheckActive[18] = 2;
            if (Xskill_CheckActive[18] == 2) X_cooldown_Area[18].SetActive(true);
        }
        if (XcooldownArea.name == ("D5_Xskillarea"))
        {
            Xskill_CheckActive[19] = 2;
            if (Xskill_CheckActive[19] == 2) X_cooldown_Area[19].SetActive(true);
        }
        if (XcooldownArea.name == ("E1_Xskillarea"))
        {
            Xskill_CheckActive[20] = 2;
            if (Xskill_CheckActive[20] == 2) X_cooldown_Area[20].SetActive(true);
        }
        if (XcooldownArea.name == ("E2_Xskillarea"))
        {
            Xskill_CheckActive[21] = 2;
            if (Xskill_CheckActive[21] == 2) X_cooldown_Area[21].SetActive(true);
        }
        if (XcooldownArea.name == ("E3_Xskillarea"))
        {
            Xskill_CheckActive[22] = 2;
            if (Xskill_CheckActive[22] == 2) X_cooldown_Area[22].SetActive(true);
        }
        if (XcooldownArea.name == ("E4_Xskillarea"))
        {
            Xskill_CheckActive[23] = 2;
            if (Xskill_CheckActive[23] == 2) X_cooldown_Area[23].SetActive(true);
        }
        if (XcooldownArea.name == ("E5_Xskillarea"))
        {
            Xskill_CheckActive[24] = 2;
            if (Xskill_CheckActive[24] == 2) X_cooldown_Area[24].SetActive(true);
        }

    }
    public void OSkill_CooldownArea(Button OcooldownArea)
    {
        if (OcooldownArea.name == ("A1_Oskillarea"))
        {
            Oskill_CheckActive[0] = 2;
            if (Oskill_CheckActive[0] == 2) O_cooldown_Area[0].SetActive(true);

        }
        if (OcooldownArea.name == ("A2_Oskillarea"))
        {
            Oskill_CheckActive[1] = 2;
            if (Oskill_CheckActive[1] == 2) O_cooldown_Area[1].SetActive(true);
        }
        if (OcooldownArea.name == ("A3_Oskillarea"))
        {
            Oskill_CheckActive[2] = 2;
            if (Oskill_CheckActive[2] == 2) O_cooldown_Area[2].SetActive(true);
        }
        if (OcooldownArea.name == ("A4_Oskillarea"))
        {
            Oskill_CheckActive[3] = 2;
            if (Oskill_CheckActive[3] == 2) O_cooldown_Area[3].SetActive(true);
        }
        if (OcooldownArea.name == ("A5_Oskillarea"))
        {
            Oskill_CheckActive[4] = 2;
            if (Oskill_CheckActive[4] == 2) O_cooldown_Area[4].SetActive(true);
        }
        if (OcooldownArea.name == ("B1_Oskillarea"))
        {
            Oskill_CheckActive[5] = 2;
            if (Oskill_CheckActive[5] == 2) O_cooldown_Area[5].SetActive(true);
        }
        if (OcooldownArea.name == ("B2_Oskillarea"))
        {
            Oskill_CheckActive[6] = 2;
            if (Oskill_CheckActive[6] == 2) O_cooldown_Area[6].SetActive(true);
        }
        if (OcooldownArea.name == ("B3_Oskillarea"))
        {
            Oskill_CheckActive[7] = 2;
            if (Oskill_CheckActive[7] == 2) O_cooldown_Area[7].SetActive(true);
        }
        if (OcooldownArea.name == ("B4_Oskillarea"))
        {
            Oskill_CheckActive[8] = 2;
            if (Oskill_CheckActive[8] == 2) O_cooldown_Area[8].SetActive(true);
        }
        if (OcooldownArea.name == ("B5_Oskillarea"))
        {
            Oskill_CheckActive[9] = 2;
            if (Oskill_CheckActive[9] == 2) O_cooldown_Area[9].SetActive(true);
        }
        if (OcooldownArea.name == ("C1_Oskillarea"))
        {
            Oskill_CheckActive[10] = 2;
            if (Oskill_CheckActive[10] == 2) O_cooldown_Area[10].SetActive(true);
        }
        if (OcooldownArea.name == ("C2_Oskillarea"))
        {
            Oskill_CheckActive[11] = 2;
            if (Oskill_CheckActive[11] == 2) O_cooldown_Area[11].SetActive(true);
        }
        if (OcooldownArea.name == ("C3_Oskillarea"))
        {
            Oskill_CheckActive[12] = 2;
            if (Oskill_CheckActive[12] == 2) O_cooldown_Area[12].SetActive(true);
        }
        if (OcooldownArea.name == ("C4_Oskillarea"))
        {
            Oskill_CheckActive[13] = 2;
            if (Oskill_CheckActive[13] == 2) O_cooldown_Area[13].SetActive(true);
        }
        if (OcooldownArea.name == ("C5_Oskillarea"))
        {
            Oskill_CheckActive[14] = 2;
            if (Oskill_CheckActive[14] == 2) O_cooldown_Area[14].SetActive(true);
        }
        if (OcooldownArea.name == ("D1_Oskillarea"))
        {
            Oskill_CheckActive[15] = 2;
            if (Oskill_CheckActive[15] == 2) O_cooldown_Area[15].SetActive(true);
        }
        if (OcooldownArea.name == ("D2_Oskillarea"))
        {
            Oskill_CheckActive[16] = 2;
            if (Oskill_CheckActive[16] == 2) O_cooldown_Area[16].SetActive(true);
        }
        if (OcooldownArea.name == ("D3_Oskillarea"))
        {
            Oskill_CheckActive[17] = 2;
            if (Oskill_CheckActive[17] == 2) O_cooldown_Area[17].SetActive(true);
        }
        if (OcooldownArea.name == ("D4_Oskillarea"))
        {
            Oskill_CheckActive[18] = 2;
            if (Oskill_CheckActive[18] == 2) O_cooldown_Area[18].SetActive(true);
        }
        if (OcooldownArea.name == ("D5_Oskillarea"))
        {
            Oskill_CheckActive[19] = 2;
            if (Oskill_CheckActive[19] == 2) O_cooldown_Area[19].SetActive(true);
        }
        if (OcooldownArea.name == ("E1_Oskillarea"))
        {
            Oskill_CheckActive[20] = 2;
            if (Oskill_CheckActive[20] == 2) O_cooldown_Area[20].SetActive(true);
        }
        if (OcooldownArea.name == ("E2_Oskillarea"))
        {
            Oskill_CheckActive[21] = 2;
            if (Oskill_CheckActive[21] == 2) O_cooldown_Area[21].SetActive(true);
        }
        if (OcooldownArea.name == ("E3_Oskillarea"))
        {
            Oskill_CheckActive[22] = 2;
            if (Oskill_CheckActive[22] == 2) O_cooldown_Area[22].SetActive(true);
        }
        if (OcooldownArea.name == ("E4_Oskillarea"))
        {
            Oskill_CheckActive[23] = 2;
            if (Oskill_CheckActive[23] == 2) O_cooldown_Area[23].SetActive(true);
        }
        if (OcooldownArea.name == ("E5_Oskillarea"))
        {
            Oskill_CheckActive[24] = 2;
            if (Oskill_CheckActive[24] == 2) O_cooldown_Area[24].SetActive(true);
        }

    }
    public void XCooldown_Count()
    {
        for (int Xcd_Count = 0; Xcd_Count < 25; Xcd_Count++)
        {
            if (Xskill_CheckActive[Xcd_Count] > 0)
            {
                Xskill_CheckActive[Xcd_Count]--;
                if (Xskill_CheckActive[Xcd_Count] <= 0)
                {
                    Xskill_CheckActive[Xcd_Count] = 0;
                    X_cooldown_Area[Xcd_Count].SetActive(false);
                }
            }
        }

    }
    public void OCooldown_Count()
    {
        for (int Ocd_Count = 0; Ocd_Count < 25; Ocd_Count++)
        {
            if (Oskill_CheckActive[Ocd_Count] > 0)
            {
                Oskill_CheckActive[Ocd_Count]--;
                if (Oskill_CheckActive[Ocd_Count] <= 0)
                {
                    Oskill_CheckActive[Ocd_Count] = 0;
                    O_cooldown_Area[Ocd_Count].SetActive(false);
                }
            }
        }

    }
    public void Play_Button()
    {
        canvas_Ative[0].SetActive(false);
        canvas_Ative[1].SetActive(true);
    }
    public void Restrat_Button()
    {
        turn_Check = 1;
        skill_Turn = 1;
        xo_Check = 0;
        count_Number = 0;
        x_Point = 0;
        o_Point = 0;
        t_Point = 0;
        X_Turn = 0;
        O_Turn = 0;
        X_skillPoint = 0;
        O_skillPoint = 0;
        Xskill_Count = 3;
        Oskill_Count = 3;
        x_HP.value = 100;
        o_HP.value = 100;
        x_Winscene.SetActive(false);
        o_Winscene.SetActive(false);
        for (int x_Num = 0;x_Num < 25; x_Num++)
        {
            WX[x_Num].SetActive(false);
        }
        for (int o_Num = 0; o_Num < 25; o_Num++)
        {
            WO[o_Num].SetActive(false);
        }
        for (int G_Num = 0; G_Num < 25; G_Num++)
        {
            grid_G[G_Num].SetActive(true);
        }

        settint_scene.SetActive(false);

    }
    public void Back_setttingButton()
    {
        settint_scene.SetActive(false);
        canvas_Ative[2].SetActive(true);
    }

    public void Setting_Button()
    {
        settint_scene.SetActive(true);
       
    }

    public void Exit_button()
    {
        Application.Quit();
    }
    public void Wincheck()
    {
        if (WX[0].activeSelf && WX[6].activeSelf && WX[12].activeSelf && WX[18].activeSelf)
        {
            O_Attack();
            WX[0].SetActive(false); 
            WX[6].SetActive(false);
            WX[12].SetActive(false);
            WX[18].SetActive(false);
            grid_G[0].SetActive(true);
            grid_G[6].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[18].SetActive(true);

            //x_Winscene.SetActive(true);
        }

        if (WO[0].activeSelf && WO[6].activeSelf && WO[12].activeSelf && WO[18].activeSelf)
        {
            X_Attack();
            WO[0].SetActive(false);
            WO[6].SetActive(false);
            WO[12].SetActive(false);
            WO[18].SetActive(false);
            grid_G[0].SetActive(true);
            grid_G[6].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[18].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[6].activeSelf && WX[12].activeSelf && WX[18].activeSelf && WX[24].activeSelf)
        {
            O_Attack();
            WX[6].SetActive(false);
            WX[12].SetActive(false);
            WX[18].SetActive(false);
            WX[24].SetActive(false);
            grid_G[6].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[24].SetActive(true);
            //x_Winscene.SetActive(true);
        }

        if (WO[6].activeSelf && WO[12].activeSelf && WO[18].activeSelf && WO[24].activeSelf)
        {
            X_Attack();
            WO[6].SetActive(false);
            WO[12].SetActive(false);
            WO[18].SetActive(false);
            WO[24].SetActive(false);
            grid_G[6].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[24].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[4].activeSelf && WX[8].activeSelf && WX[12].activeSelf && WX[16].activeSelf)
        {
            O_Attack();
            WX[4].SetActive(false);
            WX[8].SetActive(false);
            WX[12].SetActive(false);
            WX[16].SetActive(false);
            grid_G[4].SetActive(true);
            grid_G[8].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[16].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[4].activeSelf && WO[8].activeSelf && WO[12].activeSelf && WO[16].activeSelf)
        {
            X_Attack();
            WO[4].SetActive(false);
            WO[8].SetActive(false);
            WO[12].SetActive(false);
            WO[16].SetActive(false);
            grid_G[4].SetActive(true);
            grid_G[8].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[16].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[8].activeSelf && WX[12].activeSelf && WX[16].activeSelf && WX[20].activeSelf)
        {
            O_Attack();
            WX[8].SetActive(false);
            WX[12].SetActive(false);
            WX[16].SetActive(false);
            WX[20].SetActive(false);
            grid_G[8].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[16].SetActive(true);
            grid_G[20].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[8].activeSelf && WO[12].activeSelf && WO[16].activeSelf && WO[20].activeSelf)
        {
            X_Attack();
            WO[8].SetActive(false);
            WO[12].SetActive(false);
            WO[16].SetActive(false);
            WO[20].SetActive(false);
            grid_G[8].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[16].SetActive(true);
            grid_G[20].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[7].activeSelf && WX[12].activeSelf && WX[17].activeSelf && WX[22].activeSelf)
        {
            O_Attack();
            WX[7].SetActive(false);
            WX[12].SetActive(false);
            WX[17].SetActive(false);
            WX[22].SetActive(false);
            grid_G[7].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[22].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[7].activeSelf && WO[12].activeSelf && WO[17].activeSelf && WO[22].activeSelf)
        {
            X_Attack();
            WO[7].SetActive(false);
            WO[12].SetActive(false);
            WO[17].SetActive(false);
            WO[22].SetActive(false);
            grid_G[7].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[22].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[2].activeSelf && WX[7].activeSelf && WX[12].activeSelf && WX[17].activeSelf)
        {
            O_Attack();
            WX[2].SetActive(false);
            WX[7].SetActive(false);
            WX[12].SetActive(false);
            WX[17].SetActive(false);
            grid_G[2].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[17].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[2].activeSelf && WO[7].activeSelf && WO[12].activeSelf && WO[17].activeSelf)
        {
            X_Attack();
            WO[2].SetActive(false);
            WO[7].SetActive(false);
            WO[12].SetActive(false);
            WO[17].SetActive(false);
            grid_G[2].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[17].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[10].activeSelf && WX[11].activeSelf && WX[12].activeSelf && WX[13].activeSelf)
        {
            O_Attack();
            WX[10].SetActive(false);
            WX[11].SetActive(false);
            WX[12].SetActive(false);
            WX[13].SetActive(false);
            grid_G[10].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[13].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[10].activeSelf && WO[11].activeSelf && WO[12].activeSelf && WO[13].activeSelf)
        {
            X_Attack();
            WO[10].SetActive(false);
            WO[11].SetActive(false);
            WO[12].SetActive(false);
            WO[13].SetActive(false);
            grid_G[10].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[13].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[11].activeSelf && WX[12].activeSelf && WX[13].activeSelf && WX[14].activeSelf)
        {
            O_Attack();
            WX[11].SetActive(false);
            WX[12].SetActive(false);
            WX[13].SetActive(false);
            WX[14].SetActive(false);
            grid_G[11].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[14].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[11].activeSelf && WO[12].activeSelf && WO[13].activeSelf && WO[14].activeSelf)
        {
            X_Attack();
            WO[11].SetActive(false);
            WO[12].SetActive(false);
            WO[13].SetActive(false);
            WO[14].SetActive(false);
            grid_G[11].SetActive(true);
            grid_G[12].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[14].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[1].activeSelf && WX[7].activeSelf && WX[13].activeSelf && WX[19].activeSelf)
        {
            O_Attack();
            WX[1].SetActive(false);
            WX[7].SetActive(false);
            WX[13].SetActive(false);
            WX[19].SetActive(false);
            grid_G[1].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[19].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[1].activeSelf && WO[7].activeSelf && WO[13].activeSelf && WO[19].activeSelf)
        {
            X_Attack();
            WO[1].SetActive(false);
            WO[7].SetActive(false);
            WO[13].SetActive(false);
            WO[19].SetActive(false);
            grid_G[1].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[19].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[3].activeSelf && WX[7].activeSelf && WX[11].activeSelf && WX[15].activeSelf)
        {
            O_Attack();
            WX[3].SetActive(false);
            WX[7].SetActive(false);
            WX[11].SetActive(false);
            WX[15].SetActive(false);
            grid_G[3].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[15].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[3].activeSelf && WO[7].activeSelf && WO[11].activeSelf && WO[15].activeSelf)
        {
            X_Attack();
            WO[3].SetActive(false);
            WO[7].SetActive(false);
            WO[11].SetActive(false);
            WO[15].SetActive(false);
            grid_G[3].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[15].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[0].activeSelf && WX[5].activeSelf && WX[10].activeSelf && WX[15].activeSelf)
        {
            O_Attack();
            WX[0].SetActive(false);
            WX[5].SetActive(false);
            WX[10].SetActive(false);
            WX[15].SetActive(false);
            grid_G[0].SetActive(true);
            grid_G[5].SetActive(true);
            grid_G[10].SetActive(true);
            grid_G[15].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[0].activeSelf && WO[5].activeSelf && WO[10].activeSelf && WO[15].activeSelf)
        {
            X_Attack();
            WO[0].SetActive(false);
            WO[5].SetActive(false);
            WO[10].SetActive(false);
            WO[15].SetActive(false);
            grid_G[0].SetActive(true);
            grid_G[5].SetActive(true);
            grid_G[10].SetActive(true);
            grid_G[15].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[0].activeSelf && WX[1].activeSelf && WX[2].activeSelf && WX[3].activeSelf)
        {
            O_Attack();
            WX[0].SetActive(false);
            WX[1].SetActive(false);
            WX[2].SetActive(false);
            WX[3].SetActive(false);
            grid_G[0].SetActive(true);
            grid_G[1].SetActive(true);
            grid_G[2].SetActive(true);
            grid_G[3].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[0].activeSelf && WO[1].activeSelf && WO[2].activeSelf && WO[3].activeSelf)
        {
            X_Attack();
            WO[0].SetActive(false);
            WO[1].SetActive(false);
            WO[2].SetActive(false);
            WO[3].SetActive(false);
            grid_G[0].SetActive(true);
            grid_G[1].SetActive(true);
            grid_G[2].SetActive(true);
            grid_G[3].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[1].activeSelf && WX[2].activeSelf && WX[3].activeSelf && WX[4].activeSelf)
        {
            O_Attack();
            WX[1].SetActive(false);
            WX[2].SetActive(false);
            WX[3].SetActive(false);
            WX[4].SetActive(false);
            grid_G[1].SetActive(true);
            grid_G[2].SetActive(true);
            grid_G[3].SetActive(true);
            grid_G[4].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[1].activeSelf && WO[2].activeSelf && WO[3].activeSelf && WO[4].activeSelf)
        {
            X_Attack();
            WO[1].SetActive(false);
            WO[2].SetActive(false);
            WO[3].SetActive(false);
            WO[4].SetActive(false);
            grid_G[1].SetActive(true);
            grid_G[2].SetActive(true);
            grid_G[3].SetActive(true);
            grid_G[4].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[5].activeSelf && WX[11].activeSelf && WX[17].activeSelf && WX[23].activeSelf)
        {
            O_Attack();
            WX[5].SetActive(false);
            WX[11].SetActive(false);
            WX[17].SetActive(false);
            WX[23].SetActive(false);
            grid_G[5].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[23].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[5].activeSelf && WO[11].activeSelf && WO[17].activeSelf && WO[23].activeSelf)
        {
            X_Attack();
            WO[5].SetActive(false);
            WO[11].SetActive(false);
            WO[17].SetActive(false);
            WO[23].SetActive(false);
            grid_G[5].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[23].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[9].activeSelf && WX[13].activeSelf && WX[17].activeSelf && WX[21].activeSelf)
        {
            O_Attack();
            WX[9].SetActive(false);
            WX[13].SetActive(false);
            WX[17].SetActive(false);
            WX[21].SetActive(false);
            grid_G[9].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[21].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[9].activeSelf && WO[13].activeSelf && WO[17].activeSelf && WO[21].activeSelf)
        {
            X_Attack();
            WO[9].SetActive(false);
            WO[13].SetActive(false);
            WO[17].SetActive(false);
            WO[21].SetActive(false);
            grid_G[9].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[21].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[1].activeSelf && WX[6].activeSelf && WX[11].activeSelf && WX[16].activeSelf)
        {
            O_Attack();
            WX[1].SetActive(false);
            WX[6].SetActive(false);
            WX[11].SetActive(false);
            WX[16].SetActive(false);
            grid_G[1].SetActive(true);
            grid_G[6].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[16].SetActive(true);
            //x_Winscene.SetActive(true);
        }
        if (WO[1].activeSelf && WO[6].activeSelf && WO[11].activeSelf && WO[16].activeSelf)
        {
            X_Attack();
            WO[1].SetActive(false);
            WO[6].SetActive(false);
            WO[11].SetActive(false);
            WO[16].SetActive(false);
            grid_G[1].SetActive(true);
            grid_G[6].SetActive(true);
            grid_G[11].SetActive(true);
            grid_G[16].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[5].activeSelf && WX[6].activeSelf && WX[7].activeSelf && WX[8].activeSelf)
        {
            O_Attack();
            WX[5].SetActive(false);
            WX[6].SetActive(false);
            WX[7].SetActive(false);
            WX[8].SetActive(false);
            grid_G[5].SetActive(true);
            grid_G[6].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[8].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[5].activeSelf && WO[6].activeSelf && WO[7].activeSelf && WO[8].activeSelf)
        {
            X_Attack();
            WO[5].SetActive(false);
            WO[6].SetActive(false);
            WO[7].SetActive(false);
            WO[8].SetActive(false);
            grid_G[5].SetActive(true);
            grid_G[6].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[8].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[6].activeSelf && WX[7].activeSelf && WX[8].activeSelf && WX[9].activeSelf)
        {
            O_Attack();
            WX[6].SetActive(false);
            WX[7].SetActive(false);
            WX[8].SetActive(false);
            WX[9].SetActive(false);
            grid_G[6].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[8].SetActive(true);
            grid_G[9].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[6].activeSelf && WO[7].activeSelf && WO[8].activeSelf && WO[9].activeSelf)
        {
            X_Attack();
            WO[6].SetActive(false);
            WO[7].SetActive(false);
            WO[8].SetActive(false);
            WO[9].SetActive(false);
            grid_G[6].SetActive(true);
            grid_G[7].SetActive(true);
            grid_G[8].SetActive(true);
            grid_G[9].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[3].activeSelf && WX[8].activeSelf && WX[13].activeSelf && WX[18].activeSelf)
        {
            O_Attack();
            WX[3].SetActive(false);
            WX[8].SetActive(false);
            WX[13].SetActive(false);
            WX[18].SetActive(false);
            grid_G[3].SetActive(true);
            grid_G[8].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[18].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[3].activeSelf && WO[8].activeSelf && WO[13].activeSelf && WO[18].activeSelf)
        {
            X_Attack();
            WO[3].SetActive(false);
            WO[8].SetActive(false);
            WO[13].SetActive(false);
            WO[18].SetActive(false);
            grid_G[3].SetActive(true);
            grid_G[8].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[18].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[15].activeSelf && WX[16].activeSelf && WX[17].activeSelf && WX[18].activeSelf)
        {
            O_Attack();
            WX[15].SetActive(false);
            WX[16].SetActive(false);
            WX[17].SetActive(false);
            WX[18].SetActive(false);
            grid_G[15].SetActive(true);
            grid_G[16].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[18].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[15].activeSelf && WO[16].activeSelf && WO[17].activeSelf && WO[18].activeSelf)
        {
            X_Attack();
            WO[15].SetActive(false);
            WO[16].SetActive(false);
            WO[17].SetActive(false);
            WO[18].SetActive(false);
            grid_G[15].SetActive(true);
            grid_G[16].SetActive(true);
            grid_G[1].SetActive(true);
            grid_G[18].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[16].activeSelf && WX[17].activeSelf && WX[18].activeSelf && WX[19].activeSelf)
        {
            O_Attack();
            WX[16].SetActive(false);
            WX[17].SetActive(false);
            WX[18].SetActive(false);
            WX[19].SetActive(false);
            grid_G[16].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[19].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[16].activeSelf && WO[17].activeSelf && WO[18].activeSelf && WO[19].activeSelf)
        {
            X_Attack();
            WO[16].SetActive(false);
            WO[17].SetActive(false);
            WO[18].SetActive(false);
            WO[19].SetActive(false);
            grid_G[16].SetActive(true);
            grid_G[17].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[19].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[4].activeSelf && WX[9].activeSelf && WX[14].activeSelf && WX[19].activeSelf)
        {
            O_Attack();
            WX[4].SetActive(false);
            WX[9].SetActive(false);
            WX[14].SetActive(false);
            WX[19].SetActive(false);
            grid_G[4].SetActive(true);
            grid_G[9].SetActive(true);
            grid_G[14].SetActive(true);
            grid_G[19].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[4].activeSelf && WO[9].activeSelf && WO[14].activeSelf && WO[19].activeSelf)
        {
            X_Attack();
            WO[4].SetActive(false);
            WO[9].SetActive(false);
            WO[14].SetActive(false);
            WO[19].SetActive(false);
            grid_G[4].SetActive(true);
            grid_G[9].SetActive(true);
            grid_G[14].SetActive(true);
            grid_G[19].SetActive(true);
            //o_Winscene.SetActive(true);
        }


        if (WX[20].activeSelf && WX[21].activeSelf && WX[22].activeSelf && WX[23].activeSelf)
        {
            O_Attack();
            WX[20].SetActive(false);
            WX[21].SetActive(false);
            WX[22].SetActive(false);
            WX[23].SetActive(false);
            grid_G[20].SetActive(true);
            grid_G[21].SetActive(true);
            grid_G[22].SetActive(true);
            grid_G[23].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[20].activeSelf && WO[21].activeSelf && WO[22].activeSelf && WO[23].activeSelf)
        {
            X_Attack();
            WO[20].SetActive(false);
            WO[21].SetActive(false);
            WO[22].SetActive(false);
            WO[23].SetActive(false);
            grid_G[20].SetActive(true);
            grid_G[21].SetActive(true);
            grid_G[22].SetActive(true);
            grid_G[23].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[21].activeSelf && WX[22].activeSelf && WX[23].activeSelf && WX[24].activeSelf)
        {
            O_Attack();
            WX[21].SetActive(false);
            WX[22].SetActive(false);
            WX[23].SetActive(false);
            WX[24].SetActive(false);
            grid_G[21].SetActive(true);
            grid_G[22].SetActive(true);
            grid_G[23].SetActive(true);
            grid_G[24].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[21].activeSelf && WO[22].activeSelf && WO[23].activeSelf && WO[24].activeSelf)
        {
            X_Attack();
            WO[21].SetActive(false);
            WO[22].SetActive(false);
            WO[23].SetActive(false);
            WO[24].SetActive(false);
            grid_G[21].SetActive(true);
            grid_G[22].SetActive(true);
            grid_G[23].SetActive(true);
            grid_G[24].SetActive(true);
            //  o_Winscene.SetActive(true);
        }


        if (WX[9].activeSelf && WX[14].activeSelf && WX[19].activeSelf && WX[24].activeSelf)
        {
            O_Attack();
            WX[9].SetActive(false);
            WX[14].SetActive(false);
            WX[19].SetActive(false);
            WX[24].SetActive(false);
            grid_G[9].SetActive(true);
            grid_G[14].SetActive(true);
            grid_G[19].SetActive(true);
            grid_G[24].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[9].activeSelf && WO[14].activeSelf && WO[19].activeSelf && WO[24].activeSelf)
        {
            X_Attack();
            WO[9].SetActive(false);
            WO[14].SetActive(false);
            WO[19].SetActive(false);
            WO[24].SetActive(false);
            grid_G[9].SetActive(true);
            grid_G[14].SetActive(true);
            grid_G[19].SetActive(true);
            grid_G[24].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[8].activeSelf && WX[13].activeSelf && WX[18].activeSelf && WX[23].activeSelf)
        {
            O_Attack();
            WX[8].SetActive(false);
            WX[13].SetActive(false);
            WX[18].SetActive(false);
            WX[23].SetActive(false);
            grid_G[8].SetActive(true);
            grid_G[14].SetActive(true);
            grid_G[18 ].SetActive(true);
            grid_G[23].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[8].activeSelf && WO[13].activeSelf && WO[18].activeSelf && WO[23].activeSelf)
        {
            X_Attack();
            WO[8].SetActive(false);
            WO[13].SetActive(false);
            WO[18].SetActive(false);
            WO[23].SetActive(false);
            grid_G[8].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[23].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[6].activeSelf && WX[11].activeSelf && WX[16].activeSelf && WX[21].activeSelf)
        {
            O_Attack();
            WX[8].SetActive(false);
            WX[13].SetActive(false);
            WX[18].SetActive(false);
            WX[23].SetActive(false);
            grid_G[8].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[23].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[6].activeSelf && WO[11].activeSelf && WO[16].activeSelf && WO[21].activeSelf)
        {
            X_Attack();
            WO[8].SetActive(false);
            WO[13].SetActive(false);
            WO[18].SetActive(false);
            WO[23].SetActive(false);
            grid_G[8].SetActive(true);
            grid_G[13].SetActive(true);
            grid_G[18].SetActive(true);
            grid_G[23].SetActive(true);
            // o_Winscene.SetActive(true);
        }


        if (WX[5].activeSelf && WX[10].activeSelf && WX[15].activeSelf && WX[20].activeSelf)
        {
            O_Attack();
            WX[5].SetActive(false);
            WX[10].SetActive(false);
            WX[15].SetActive(false);
            WX[20].SetActive(false);
            grid_G[5].SetActive(true);
            grid_G[10].SetActive(true);
            grid_G[15].SetActive(true);
            grid_G[20].SetActive(true);
            // x_Winscene.SetActive(true);
        }
        if (WO[5].activeSelf && WO[10].activeSelf && WO[15].activeSelf && WO[20].activeSelf)
        {
            X_Attack();
            WO[5].SetActive(false);
            WO[10].SetActive(false);
            WO[15].SetActive(false);
            WO[20].SetActive(false);
            grid_G[5].SetActive(true);
            grid_G[10].SetActive(true);
            grid_G[15].SetActive(true);
            grid_G[20].SetActive(true);

            // o_Winscene.SetActive(true);
        }

        if (x_HP.value <= 0)
        {
            o_Winscene.SetActive(true);
        }
        if (o_HP.value <= 0)
        {
            x_Winscene.SetActive(true);
        }
    }
    public void Opption_menu()
    {
        option[0].SetActive(true);
        option[1].SetActive(false);

    }
    public void BackOpption_menu()
    {
        option[0].SetActive(false);
        option[1].SetActive(true);

    }
    public void Back_Menu()
    {
        game_scene[0].SetActive(false);
        game_scene[1].SetActive(true);
    } 
    public void X_Attack()
    {
        x_HP.value = x_HP.value - o_Damage;
    }
    public void O_Attack()
    {
        o_HP.value = o_HP.value - x_Damage;
    }
   
}

  


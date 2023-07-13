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


    [Header("variable for Win check")]
    [SerializeField] public GameObject[] WX;
    [SerializeField] public GameObject[] WO;






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

        }
        if (count_Number % 2 == 0)
        {
            turn_Active[1].SetActive(true);
            turn_Active[0].SetActive(false);


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
    public void Wincheck()
    {
        if (WX[0].activeSelf && WX[6].activeSelf && WX[12].activeSelf && WX[18].activeSelf)
        {
            Debug.Log("X win 1");
        }

        if (WO[0].activeSelf && WO[6].activeSelf && WO[12].activeSelf && WO[18].activeSelf)
        {
            Debug.Log("O win 1");
        }
        if (WX[6].activeSelf && WX[12].activeSelf && WX[18].activeSelf && WX[24].activeSelf)
        {
            Debug.Log("X win 2");
        }

        if (WO[6].activeSelf && WO[12].activeSelf && WO[18].activeSelf && WO[24].activeSelf)
        {
            Debug.Log("O win 2");
        }
        if (WX[4].activeSelf && WX[8].activeSelf && WX[12].activeSelf && WX[16].activeSelf)
        {
            Debug.Log("X win 3");
        }

        if (WO[4].activeSelf && WO[8].activeSelf && WO[12].activeSelf && WO[16].activeSelf)
        {
            Debug.Log("O win 3");
        }
        if (WX[8].activeSelf && WX[12].activeSelf && WX[16].activeSelf && WX[20].activeSelf)
        {
            Debug.Log("X win 4");
        }
        if (WO[8].activeSelf && WO[12].activeSelf && WO[16].activeSelf && WO[20].activeSelf)
        {
            Debug.Log("O win 4");
        }
        if (WX[7].activeSelf && WX[12].activeSelf && WX[17].activeSelf && WX[22].activeSelf)
        {
            Debug.Log("X win 5");
        }

        if (WO[7].activeSelf && WO[12].activeSelf && WO[17].activeSelf && WO[22].activeSelf)
        {
            Debug.Log("O win 5");
        }
        if (WX[2].activeSelf && WX[7].activeSelf && WX[12].activeSelf && WX[17].activeSelf)
        {
            Debug.Log("X win 6");
        }
        if (WO[2].activeSelf && WO[7].activeSelf && WO[12].activeSelf && WO[17].activeSelf)
        {
            Debug.Log("O win 6");
        }
        if (WX[10].activeSelf && WX[11].activeSelf && WX[12].activeSelf && WX[13].activeSelf)
        {
            Debug.Log("X win 7");
        }
        if (WO[10].activeSelf && WO[11].activeSelf && WO[12].activeSelf && WO[13].activeSelf)
        {
            Debug.Log("O win 7");
        }
        if (WX[11].activeSelf && WX[12].activeSelf && WX[13].activeSelf && WX[14].activeSelf)
        {
            Debug.Log("X win 8");
        }
        if (WO[11].activeSelf && WO[12].activeSelf && WO[13].activeSelf && WO[14].activeSelf)
        {
            Debug.Log("O win 8");
        }
        if (WX[1].activeSelf && WX[7].activeSelf && WX[13].activeSelf && WX[19].activeSelf)
        {
            Debug.Log("X win 9");
        }
        if (WO[1].activeSelf && WO[7].activeSelf && WO[13].activeSelf && WO[19].activeSelf)
        {
            Debug.Log("O win 9");
        }
        if (WX[3].activeSelf && WX[7].activeSelf && WX[11].activeSelf && WX[15].activeSelf)
        {
            Debug.Log("X win 10");
        }
        if (WO[3].activeSelf && WO[7].activeSelf && WO[11].activeSelf && WO[15].activeSelf)
        {
            Debug.Log("O win 10");
        }
        if (WX[0].activeSelf && WX[5].activeSelf && WX[10].activeSelf && WX[15].activeSelf)
        {
            Debug.Log("X win 11");
        }
        if (WO[0].activeSelf && WO[5].activeSelf && WO[10].activeSelf && WO[15].activeSelf)
        {
            Debug.Log("O win 11");
        }
        if (WX[0].activeSelf && WX[1].activeSelf && WX[2].activeSelf && WX[3].activeSelf)
        {
            Debug.Log("X win 12");
        }
        if (WO[0].activeSelf && WO[1].activeSelf && WO[2].activeSelf && WO[3].activeSelf)
        {
            Debug.Log("O win 12");
        }
        if (WX[1].activeSelf && WX[2].activeSelf && WX[3].activeSelf && WX[4].activeSelf)
        {
            Debug.Log("X win 13");
        }
        if (WO[1].activeSelf && WO[2].activeSelf && WO[3].activeSelf && WO[4].activeSelf)
        {
            Debug.Log("O win 13");
        }
        if (WX[5].activeSelf && WX[11].activeSelf && WX[17].activeSelf && WX[23].activeSelf)
        {
            Debug.Log("X win 14");
        }
        if (WO[5].activeSelf && WO[11].activeSelf && WO[17].activeSelf && WO[23].activeSelf)
        {
            Debug.Log("O win 14");
        }
        if (WX[9].activeSelf && WX[13].activeSelf && WX[17].activeSelf && WX[21].activeSelf)
        {
            Debug.Log("X win 15");
        }
        if (WO[9].activeSelf && WO[13].activeSelf && WO[17].activeSelf && WO[21].activeSelf)
        {
            Debug.Log("O win 15");
        }
        if (WX[1].activeSelf && WX[6].activeSelf && WX[11].activeSelf && WX[16].activeSelf)
        {
            Debug.Log("X win 16");
        }
        if (WO[1].activeSelf && WO[6].activeSelf && WO[11].activeSelf && WO[16].activeSelf)
        {
            Debug.Log("O win 16");
        }
        if (WX[5].activeSelf && WX[6].activeSelf && WX[7].activeSelf && WX[8].activeSelf)
        {
            Debug.Log("X win 17");
        }
        if (WO[5].activeSelf && WO[6].activeSelf && WO[7].activeSelf && WO[8].activeSelf)
        {
            Debug.Log("O win 17");
        }
        if (WX[6].activeSelf && WX[7].activeSelf && WX[8].activeSelf && WX[9].activeSelf)
        {
            Debug.Log("X win 18");
        }
        if (WO[6].activeSelf && WO[7].activeSelf && WO[8].activeSelf && WO[9].activeSelf)
        {
            Debug.Log("O win 18");
        }
        if (WX[3].activeSelf && WX[8].activeSelf && WX[13].activeSelf && WX[18].activeSelf)
        {
            Debug.Log("X win 19");
        }
        if (WO[3].activeSelf && WO[8].activeSelf && WO[13].activeSelf && WO[18].activeSelf)
        {
            Debug.Log("O win 19");
        }
        if (WX[15].activeSelf && WX[16].activeSelf && WX[17].activeSelf && WX[18].activeSelf)
        {
            Debug.Log("X win 20");
        }
        if (WO[15].activeSelf && WO[16].activeSelf && WO[17].activeSelf && WO[18].activeSelf)
        {
            Debug.Log("O win 20");
        }
        if (WX[16].activeSelf && WX[17].activeSelf && WX[18].activeSelf && WX[19].activeSelf)
        {
            Debug.Log("X win 21");
        }
        if (WO[16].activeSelf && WO[17].activeSelf && WO[18].activeSelf && WO[19].activeSelf)
        {
            Debug.Log("O win 21");
        }
        if (WX[4].activeSelf && WX[9].activeSelf && WX[14].activeSelf && WX[19].activeSelf)
        {
            Debug.Log("X win 22");
        }
        if (WO[4].activeSelf && WO[9].activeSelf && WO[14].activeSelf && WO[19].activeSelf)
        {
            Debug.Log("O win 22");
        }
        if (WX[20].activeSelf && WX[21].activeSelf && WX[22].activeSelf && WX[23].activeSelf)
        {
            Debug.Log("X win 23");
        }
        if (WO[20].activeSelf && WO[21].activeSelf && WO[22].activeSelf && WO[23].activeSelf)
        {
            Debug.Log("O win 23");
        }
        if (WX[21].activeSelf && WX[22].activeSelf && WX[23].activeSelf && WX[24].activeSelf)
        {
            Debug.Log("X win 24");
        }
        if (WO[21].activeSelf && WO[22].activeSelf && WO[23].activeSelf && WO[24].activeSelf)
        {
            Debug.Log("O win 24");
        }
        if (WX[9].activeSelf && WX[14].activeSelf && WX[19].activeSelf && WX[24].activeSelf)
        {
            Debug.Log("X win 25");
        }
        if (WO[9].activeSelf && WO[14].activeSelf && WO[19].activeSelf && WO[24].activeSelf)
        {
            Debug.Log("O win 25");
        }
        if (WX[8].activeSelf && WX[13].activeSelf && WX[18].activeSelf && WX[23].activeSelf)
        {
            Debug.Log("X win 26");
        }
        if (WO[8].activeSelf && WO[13].activeSelf && WO[18].activeSelf && WO[23].activeSelf)
        {
            Debug.Log("O win 26");
        }
        if (WX[6].activeSelf && WX[11].activeSelf && WX[16].activeSelf && WX[21].activeSelf)
        {
            Debug.Log("X win 27");
        }
        if (WO[6].activeSelf && WO[11].activeSelf && WO[16].activeSelf && WO[21].activeSelf)
        {
            Debug.Log("O win 27");
        }
        if (WX[5].activeSelf && WX[10].activeSelf && WX[15].activeSelf && WX[20].activeSelf)
        {
            Debug.Log("X win 28");
        }
        if (WO[5].activeSelf && WO[10].activeSelf && WO[15].activeSelf && WO[20].activeSelf)
        {
            Debug.Log("O win 28");
        }
    }
}

  


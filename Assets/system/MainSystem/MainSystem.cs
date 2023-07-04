using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSystem : MonoBehaviour
{
    [Header("variable for turncheck , value")]
    [SerializeField] public static int turn_Check = 1;
    [SerializeField] public static int xo_Check;
    [SerializeField] public static int count_Number;
    [SerializeField] public static int x_Point;
    [SerializeField] public static int o_Point;
    [SerializeField] public static int t_Point;

    [Header("variable for Skill System")]
    [SerializeField] public GameObject[] X_skill;
    [SerializeField] public GameObject[] O_skill;
    [SerializeField] public GameObject[] X_skillUsed;
    [SerializeField] public GameObject[] O_skillUsed;
    [SerializeField] public GameObject[] X_Space;
    [SerializeField] public GameObject[] O_Space;
    [SerializeField] public GameObject[] X_Skillcontrol;
    [SerializeField] public GameObject[] O_Skillcontrol;

    [SerializeField] public GameObject X_Usebutton;
    [SerializeField] public GameObject O_Usebutton;


    [SerializeField] public static int X_Turn;
    [SerializeField] public static int O_Turn;
    [SerializeField] public static int X_skillPoint;
    [SerializeField] public static int O_skillPoint;
    [SerializeField] public static int Xskill_Count = 3;
    [SerializeField] public static int Oskill_Count = 3;





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
            
            X.SetActive(true);
            X_Turn++;
        }
        if (count_Number % 2 == 0)
        {
            O.SetActive(true);
            O_Turn++;
        }
        Box.SetActive(false);
        
    }
    public void Turn_Count()
    {
        if (count_Number % 2 == 0)
        {
            turn_Check++;
        }
        
    }

    public void Skill_count()
    {
        if (X_Turn >= 3 )
        {
            X_skillPoint++;
            X_Turn = 0;
        }
        if (O_Turn >= 3)
        {
            O_skillPoint++;
            O_Turn = 0;
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

        /*------------------------------ skillUsedbutton ---------------------*/


        if (X_skill[0].activeSelf == true || X_skill[1].activeSelf == true || X_skill[2].activeSelf == true  )
        {
            if (count_Number % 2 != 0)
            {
                X_Usebutton.SetActive(true);
            }
            else { X_Usebutton.SetActive(false); }

        } 

        if (O_skill[0].activeSelf == true || O_skill[1].activeSelf == true || O_skill[2].activeSelf == true && count_Number % 2 == 0)
        {
            if (count_Number % 2 == 0)
            {
                O_Usebutton.SetActive(true);
            }
            else { O_Usebutton.SetActive(false); }
        }
       


    }
    
    public void XSkill_Use()
    {
        X_skillPoint--;
        Xskill_Count--;
        X_Affectskillspace();
    }
    public void OSkill_Use()
    {
        O_skillPoint--;
        Oskill_Count--;
        O_Affectskillspace();
        

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
    public void Wincheck()
    {
       //updating for 5*5 soon

    }
}

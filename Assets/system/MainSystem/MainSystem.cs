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
    [SerializeField] public GameObject[] Tie;





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

    }
    public void OSkill_Use()
    {
        O_skillPoint--;
        Oskill_Count--;
    }

    public void Wincheck()
    {
       //updating for 5*5 soon

    }
}

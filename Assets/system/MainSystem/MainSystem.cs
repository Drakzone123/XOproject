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
    
    [SerializeField] public static int X_Turn;
    [SerializeField] public static int O_Turn;
    [SerializeField] public static int X_skillPoint;
    [SerializeField] public static int O_skillPoint;
    




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
        if (X_Turn >= 3) X_Turn = 3;
        if (O_Turn >= 3) O_Turn = 3;



    } 

    public void Skill_Active()
    {
        if (X_skillPoint == 1) X_skill[0].SetActive(true);
        if (X_skillPoint == 2) X_skill[1].SetActive(true);
        if (X_skillPoint == 3) X_skill[2].SetActive(true);

        if (O_skillPoint == 1) O_skill[0].SetActive(true);
        if (O_skillPoint == 2) O_skill[1].SetActive(true);
        if (O_skillPoint == 3) O_skill[2].SetActive(true);

    }

    public void Wincheck()
    {
       //updating for 5*5 soon

    }
}

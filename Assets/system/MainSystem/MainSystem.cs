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
        if (count_Number % 2 != 0) X.SetActive(true);
        if (count_Number % 2 == 0) O.SetActive(true);
        Box.SetActive(false);
        
    }
    public void Turn_Count()
    {
        if (count_Number % 2 == 0) turn_Check++;

    }

    public void Wincheck()
    {
       //updating for 5*5 soon
       
    }
}

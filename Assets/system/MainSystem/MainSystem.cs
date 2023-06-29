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
        if (WX[0].activeSelf == true && WX[1].activeSelf == true && WX[2].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WX[3].activeSelf == true && WX[4].activeSelf == true && WX[5].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WX[6].activeSelf == true && WX[7].activeSelf == true && WX[8].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }

        if (WX[0].activeSelf == true && WX[3].activeSelf == true && WX[6].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WX[1].activeSelf == true && WX[4].activeSelf == true && WX[7].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WX[2].activeSelf == true && WX[5].activeSelf == true && WX[8].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }

        if (WX[0].activeSelf == true && WX[4].activeSelf == true && WX[8].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WX[2].activeSelf == true && WX[4].activeSelf == true && WX[6].activeSelf == true) { x_Point++; SceneManager.LoadScene("ScoreCount"); }

        if (WO[0].activeSelf == true && WO[1].activeSelf == true && WO[2].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WO[3].activeSelf == true && WO[4].activeSelf == true && WO[5].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WO[6].activeSelf == true && WO[7].activeSelf == true && WO[8].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }

        if (WO[0].activeSelf == true && WO[3].activeSelf == true && WO[6].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WO[1].activeSelf == true && WO[4].activeSelf == true && WO[7].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WO[2].activeSelf == true && WO[5].activeSelf == true && WO[8].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }

        if (WO[0].activeSelf == true && WO[4].activeSelf == true && WO[8].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }
        if (WO[2].activeSelf == true && WO[4].activeSelf == true && WO[6].activeSelf == true) { o_Point++; SceneManager.LoadScene("ScoreCount"); }

        if (Tie[0].activeSelf == false && Tie[1].activeSelf == false && Tie[2].activeSelf == false && Tie[3].activeSelf == false && Tie[4].activeSelf == false && Tie[5].activeSelf == false && Tie[6].activeSelf == false && Tie[7].activeSelf == false && Tie[8].activeSelf == false) { t_Point++; SceneManager.LoadScene("ScoreCount"); }
    }
}

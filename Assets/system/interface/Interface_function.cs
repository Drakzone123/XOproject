using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Interface_function : MainSystem
{
    [Header("Text for Turn counting")]
    [SerializeField] public TextMeshProUGUI turn_number;
    

    [Header("Text for point counting")]
    [SerializeField] public TextMeshProUGUI x_potintCount;
    [SerializeField] public TextMeshProUGUI o_potintCount;
    [SerializeField] public TextMeshProUGUI t_potintCount;

    [Header("variable for popup")]
    [SerializeField] public GameObject canvaspopup_Setting;

    public void Turn_counted()
    {
        if (count_Number <= 1)
        {
            turn_number.text = "Turn: 1";
        }
        else
        { 
            turn_number.text = "Turn: " + turn_Check; 
        }
        
        
    }

    public void Point_count()
    {
        x_potintCount.text = "X = " + x_Point;
        o_potintCount.text = "O = " + o_Point;
        t_potintCount.text = "TIE = " + t_Point;
    }
    public void Again_botton()
    {
        turn_Check = 1;
        count_Number = 0;
        SceneManager.LoadScene("ingame");
    }
    public void Exit_botton()
    {
        Application.Quit();
    }


}

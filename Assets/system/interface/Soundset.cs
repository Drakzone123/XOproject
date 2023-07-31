using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Soundset : MonoBehaviour
{
    [SerializeField] Slider sound_Bar;
    [SerializeField] Toggle sound_Tog;
    [SerializeField] GameObject[] window_Setting;
    [SerializeField] AudioSource sound_BMG;

   
   public void Soundslide_setting()
    {
       if (sound_Tog.isOn)
        {
            sound_BMG.volume = sound_Bar.value;
        }

    }
    public void Soundtogger_setting()
    {
       if (sound_Tog.isOn == false)
        {
            sound_BMG.volume = 0;
        }
        else
        {
            sound_BMG.volume = sound_Bar.value;
        }

    }
    public void Back_Soundsetbut()
    {
        window_Setting[0].SetActive(false);
        window_Setting[1].SetActive(true);
    }
    public void Go_voluneset()
    {
        window_Setting[0].SetActive(true);
        window_Setting[1].SetActive(false);
    }
}

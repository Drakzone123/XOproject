using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skillpoint_sound : MonoBehaviour
{
    [SerializeField] AudioSource skillpoint_Sound;

    public void OnEnable()
    {
        skillpoint_Sound.Play();
    }
}

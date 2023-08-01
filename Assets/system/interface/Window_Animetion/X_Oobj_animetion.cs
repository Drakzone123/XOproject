using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Oobj_animetion : MonoBehaviour
{
   
   


    public void OnEnable()
    {
        transform.localScale = Vector2.zero;
        transform.LeanScale(Vector2.one, 0.2f).setEaseInOutBounce();
    }
    public void OnDisable()
    {
        transform.LeanScale(Vector2.zero, 0.2f).setEaseInBack();
    }
}

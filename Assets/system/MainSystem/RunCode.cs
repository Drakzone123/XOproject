using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCode : MainSystem
{
    private void FixedUpdate()
    {
        Skill_Active();
        Turn_Active();
        Wincheck();
        
        
    }
}

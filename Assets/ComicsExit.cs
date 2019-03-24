using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicsExit : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Application.LoadLevel("Main");
    }
}

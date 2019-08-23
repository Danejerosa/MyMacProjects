using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {

        IAction currentAction = null;

        public void StartAction(IAction action)
        {
            if (currentAction == null) return;
            if(currentAction != null)
            {
                currentAction.Cancel();
            }
    
            currentAction = action;
        }

        public void CancelCurrentAction()
        {
            StartAction(null);
        }


    }
}

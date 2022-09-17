using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiTrigger : MonoBehaviour
{
    public GameObject Box;

    private void ExecuteTrigger(int trigger)
    {
        if(Box != null)
        {
            var animator = Box.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }

    public void buttonHover()
    {
        ExecuteTrigger(1);
        Debug.Log("One");
    }
    public void buttonClick()
    {
        ExecuteTrigger(2);
        Debug.Log("Two");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overButton : MonoBehaviour
{
    public GameObject Cube;

    private void ExecuteTrigger(int trigger)
    {
        if(Cube != null)
        {
            var animator = Cube.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }

    void OnMouseOver()
    {
        ExecuteTrigger(1);
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        ExecuteTrigger(0);
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }

}

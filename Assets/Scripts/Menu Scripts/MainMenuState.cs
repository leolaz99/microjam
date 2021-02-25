using UnityEngine;

public class MainMenuState : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FindObjectOfType<MainMenu>(true).ToggleMenu(true);       
    }
 
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
   
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        FindObjectOfType<MainMenu>(true).ToggleMenu(false);
    }
}

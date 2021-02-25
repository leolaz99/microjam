using UnityEngine;
using UnityEngine.UI;
using LLFramework;

public class MainMenu : UI_MenuBase
{
    [SerializeField] Animator anim;
	[SerializeField] Button goToGameplayButton;
	[SerializeField] Button goToExitButton;

	public override void ToggleMenu(bool _value)
    {
        base.ToggleMenu(_value);
    }

	void ActionGoToSettings()
	{
		anim.SetTrigger("GoToGame");
	}

	void ActionGoToExit()
	{
		anim.SetTrigger("GoToExit");
	}


	void Awake()
	{
		if (goToGameplayButton != null)
		{
			Button actualGoToSettingsButton = goToGameplayButton.GetComponent<Button>();
			actualGoToSettingsButton.onClick.AddListener(ActionGoToSettings);		
		}

		if(goToExitButton != null)
        {
			Button actualGoToExitButton = goToExitButton.GetComponent<Button>();
			actualGoToExitButton.onClick.AddListener(ActionGoToExit);
        }
	}
}

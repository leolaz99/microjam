using LLFramework;

public class Gameplay : UI_MenuBase
{
    public override void ToggleMenu(bool _value)
    {
        base.ToggleMenu(_value);
    }

    void Awake()
    {
        ToggleMenu(false);
    }
}

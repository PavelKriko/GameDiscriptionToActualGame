namespace Game.src.GameCore;
public class ConditionCommand : ICommand
{
    private readonly ICommand _condition;
    private readonly ICommand _thencommand;
    private readonly ICommand? _elsecommand;

    public ConditionCommand(ICommand condition, ICommand thencommand, ICommand? elsecommand = null)
    {
        _condition = condition ?? throw new ArgumentNullException(nameof(condition));
        _thencommand = thencommand ?? throw new ArgumentNullException(nameof(thencommand));
        _elsecommand = elsecommand;
    }
    public void Execute()
    {
        try
        {
            _condition.Execute();
        }
        catch (Exception)
        {
            _elsecommand?.Execute();
            return;
        }
        _thencommand.Execute();
    }

}

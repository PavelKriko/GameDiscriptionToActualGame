namespace Game.src.GameCore;
public class Macrocommand(IEnumerable<ICommand> _commands) : ICommand
{
    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}

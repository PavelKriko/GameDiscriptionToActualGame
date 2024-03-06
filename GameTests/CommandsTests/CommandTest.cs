using Game.src.GameCore;

namespace GameTests.CommandsTests;
public class CommandTest
{
    [Fact]
    public void All_commands_was_called_in_macrocommand()
    {
        var mockList = new List<Mock<ICommand>>();
        var commandList = new List<ICommand>();
        for (int i = 0; i < 3; i++)
        {
            var cmd = new Mock<ICommand>();
            mockList.Add(cmd);
            commandList.Add(cmd.Object);
        }

        Macrocommand mcmd = new Macrocommand(commandList);
        mcmd.Execute();
        foreach (var cmd in mockList)
        {
            cmd.Verify(x => x.Execute(), Times.Once);
        }
    }


    [Fact]
    public void Thencommand_work_with_true_condition()
    {
        var condition = new Mock<ICommand>();
        var thencommand = new Mock<ICommand>();
        var elsecommand = new Mock<ICommand>();

        ConditionCommand concmd = new ConditionCommand(condition.Object, thencommand.Object);
        concmd.Execute();

        condition.Verify(x => x.Execute(), Times.Once);
        thencommand.Verify(x => x.Execute(), Times.Once);
        elsecommand.Verify(x => x.Execute(), Times.Never);

    }

    [Fact]
    public void Thencommand_not_work_with_false_condtition()
    {
        var condition = new Mock<ICommand>();
        condition.Setup(x => x.Execute()).Throws(new Exception());

        var thencommand = new Mock<ICommand>();
        var elsecommand = new Mock<ICommand>();

        ConditionCommand concmd = new ConditionCommand(condition.Object, thencommand.Object, elsecommand.Object);
        concmd.Execute();

        condition.Verify(x => x.Execute(), Times.Once);
        thencommand.Verify(x => x.Execute(), Times.Never);
        elsecommand.Verify(x => x.Execute(), Times.Once);
    }


}

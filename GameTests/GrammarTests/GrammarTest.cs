using Antlr4.Runtime;
namespace GameTests.GrammarTests;
public class GrammarTest
{
    [Fact]
    public void Current_string_respond_grammar()
    {
        string pathToTextFile = "../../../ParserTests/TestText.txt";
        string str = File.ReadAllText(pathToTextFile);

        // Создание входного потока ANTLR из файла XML
        AntlrInputStream input = new AntlrInputStream(str);
        // Создание лексера
        GameLexer lexer = new GameLexer(input);
        // Создание токен-стрима на основе лексера
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        // Создание парсера
        GameParser parser = new GameParser(tokens);
        Assert.Equal(0, parser.NumberOfSyntaxErrors);
    }
}

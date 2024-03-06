using System.Xml;
using Game.src.FileParsers;
namespace GameTests.ParserTests;
public class XMLParserTests
{
    [Fact]
    public void ConvertToString_returns_expected_result()
    {

        //Как это нормально указать ???
        string pathToXML = "../../../ParserTests/TestXML.xml";
        string pathToText = "../../../ParserTests/TestText.txt";

        var document = new XmlDocument();
        document.Load(pathToXML);
        IParserFileToString parser = new XMLParser(document);
        string currentValue = parser.ConvertToString();

        string expectedValue = File.ReadAllText(pathToText);
        Assert.Equal(expectedValue, currentValue);
    }
}
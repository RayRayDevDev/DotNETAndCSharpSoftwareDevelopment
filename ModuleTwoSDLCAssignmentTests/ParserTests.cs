using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Tests
{
    [TestClass()]
    public class ParserTests
    {
        private IEnumerable<string> matches;

        [TestMethod()]
        public void countOccurencesTest_NoElementsInList_ReturnsFalse()
        {
            //Arrange

            var parser = new Parser();
            var list = new List<String>(0);
            //Act

            bool test1 = parser.countOccurences(list);


            //Assert
            Assert.IsTrue(test1);
        }

        [TestMethod()]
        public void readAndParseFileTest()
        {
            Parser parser = new Parser();
            var inputMixedCaseFile = new string(@"Text_File\The_Raven--EAP.txt");
            var outputToLowercase = new string(@"Text_File\The_Raven--EAP_Output.txt");
            var toLowercase = File.ReadAllText(inputMixedCaseFile);
            toLowercase = toLowercase.ToLower();
            File.WriteAllText(outputToLowercase, toLowercase);
            var pattern = @"\w+"; 
            var regex = new Regex(pattern);
            matches = regex.Matches(File.ReadAllText(outputToLowercase)).OfType<Match>().Select(m => m.Value); 
            matches = new List<string>(matches); 
            parser.countOccurences((List<string>)matches);

        }
    }
}
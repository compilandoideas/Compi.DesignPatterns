using Compi.DesignPatterns.Rules;
using Compi.DesignPatterns.Rules.Model;
using Compi.DesignPatterns.RulesEngine.Rules;
using Compi.DesignPatterns.Test.Common;
using System.Globalization;

namespace Compi.DesignPatterns.Test.Rules
{
    [TestClass]
    public class RuleEngineTest : TestBase
    {


        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            // TODO: Initialize for all tests in class
            tc.WriteLine("Init class");

            //_sut = new GetPositionService();

        }



        [TestMethod]
        [Description("Evalua que la marca corresponda a entrada a colación según el turno")]
        [Owner("Eduardo")]
        [Priority(1)]
        [DataRow("04/08/2022 09:00:00", "04/08/2022 13:00:00", "04/08/2022 14:00:00", "04/08/2022 19:00:00", "04/08/2022 13:30:00")]
        public void Record_In_Entry_To_Shift(string shiftEntryTest, string shiftEntryToLunchTest, string shiftEndOfLunchTimeTest, string shiftDepartureTest, string recordTest)
        {

            //Arrange

            CultureInfo culture = new CultureInfo("es-CL");
            DateTime shiftEntry = Convert.ToDateTime(shiftEntryTest, culture);
            DateTime shiftEntryToLunch = Convert.ToDateTime(shiftEntryToLunchTest, culture);
            DateTime shiftEndOfLunchTime = Convert.ToDateTime(shiftEndOfLunchTimeTest, culture);
            DateTime shiftDeparture = Convert.ToDateTime(shiftDepartureTest, culture);

            DateTime record2 = Convert.ToDateTime(recordTest, culture);


            var record = new Record();
            record.ShiftEntry = shiftEntry;
            record.ShiftDeparture = shiftDeparture;



            IEnumerable<IRule?> rules = typeof(IRule).Assembly.GetTypes()
                .Where(x => typeof(IRule).IsAssignableFrom(x) && !x.IsInterface)
                .Select(x => Activator.CreateInstance(x) as IRule);

            //rules.Add(new IsStartShift());

            //Act

            var engine = new RuleEngine(rules);

            var result = engine.Calculate(record);

            //Assert

            Assert.IsTrue(result.IsStartShift == true, "Entrada al Turno");

        }



        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine($"TestCleanup {TestContext.TestName}");

        }


        [ClassCleanup()]
        public static void ClassCleanup()
        {
            // TODO: Clean up after all tests in class


        }
    }
}
using NUnit.Framework;
using OpgaveBibliotek;
using System;

namespace TestProject1
{
    public class Tests
    {
        Class1 _class1 = null;
        
        [SetUp]
        public void Setup()
        {
            _class1 = new Class1();
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassIsZero_Shh_Test()
        {
            //Act � Handling.
            var result = _class1.WeCheerIfGoalOrPasses("TESSSST", 0);

            //Assert � P�stand
            Assert.AreEqual("Shh", result);
        }

        [Test]
        public void HowHappyAreWeAboutThePasses_PassIsNegativValue_Error_Test()
        {
            
            var result = _class1.WeCheerIfGoalOrPasses("TESSSST", -1);

            
            Assert.AreEqual("ERROR - Are your team playing backwords???", result);
        }

        [Test]
        public void HowHappyAreWeAboutThePasses_PassIstree_HuhHuhHuh_Test()
        {
            
            var result = _class1.WeCheerIfGoalOrPasses(string.Empty, 3);

            
            Assert.AreEqual("Huh! Huh! Huh!", result);
        }

        [Test]
        public void HowHappyAreWeAboutThePasses_PassesIsTin_HighFiveJubel_Test()
        {
            var result = _class1.WeCheerIfGoalOrPasses("LoL", 10);

            Assert.AreEqual("High Five - Jubel!!!", result);
        }

        [Test]
        public void WeCheerIfGoal_GoalIsM�L_OleOleOle_Test()
        {
            var result = _class1.WeCheerIfGoalOrPasses("M�L", 0);

            Assert.AreEqual("Ol� ol� ol�", result);
        }

        [Test]
        public void WeCheerGoalOrPasses_GoalIsm�l_OleOleOle_Test()
        {
            var result = _class1.WeCheerIfGoalOrPasses("m�l", 4);
            Assert.AreEqual("Ol� ol� ol�", result);
        }
    }
}
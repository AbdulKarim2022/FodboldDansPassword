using NUnit.Framework;
using OpgaveBibliotek;
using System;

namespace TestProject1
{
    public class Tests
    {
        Football _class1 = null;
        
        [SetUp]
        public void Setup()
        {
            _class1 = new Football();
        }
        [Test]
        public void HowHappyAreWeAboutThePasses_PassIsZero_Shh_Test()
        {
            //Act – Handling.
            var result = _class1.WeCheerIfGoalOrPasses("TESSSST", 0);

            //Assert – Påstand
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
        public void WeCheerIfGoal_GoalIsMåL_OleOleOle_Test()
        {
            var result = _class1.WeCheerIfGoalOrPasses("MåL", 0);

            Assert.AreEqual("Olé olé olé", result);
        }

        [Test]
        public void WeCheerGoalOrPasses_GoalIsmÅl_OleOleOle_Test()
        {
            var result = _class1.WeCheerIfGoalOrPasses("mÅl", 4);
            Assert.AreEqual("Olé olé olé", result);
        }
    }
}
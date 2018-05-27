﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GameEngine.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Make a step")]
    public partial class MakeAStepFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Make a step.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Make a step", "\tTo make a step\r\n\tAs a game engine\r\n\tI want to set cell value on game place", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make a step in cell x = 0 y = 1")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("0")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("1")]
        public virtual void MakeAStepInCellX0Y1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a step in cell x = 0 y = 1", new string[] {
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "0",
                        "y",
                        "=",
                        "1"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have a game engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I create game place size 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I add a player with parameters (name = \"player1\" token = \"X\" id = 1) to the game " +
                    "engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I make a step in cell x = 0 y = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("The value of the cell in x = 0 y = 1 must equal the value of the player token wit" +
                    "h id = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make a step in cell x = 2 y = 2")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("2")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("2")]
        public virtual void MakeAStepInCellX2Y2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a step in cell x = 2 y = 2", new string[] {
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "2",
                        "y",
                        "=",
                        "2"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("I have a game engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("I create game place size 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.And("I add a player with parameters (name = \"player1\" token = \"X\" id = 1) to the game " +
                    "engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I make a step in cell x = 2 y = 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("The value of the cell in x = 2 y = 2 must equal the value of the player token wit" +
                    "h id = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("0")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("0")]
        [NUnit.Framework.CategoryAttribute("and")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("1")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("1")]
        public virtual void MakeAStepInCellX0Y0AndMakeAStepInCellX1Y1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1", new string[] {
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "0",
                        "y",
                        "=",
                        "0",
                        "and",
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "1",
                        "y",
                        "=",
                        "1"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("I have a game engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.When("I create game place size 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("I add a player with parameters (name = \"player1\" token = \"X\" id = 1) to the game " +
                    "engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I add a player with parameters (name = \"player2\" token = \"Y\" id = 2) to the game " +
                    "engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I make a step in cell x = 0 y = 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I make a step in cell x = 1 y = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("The value of the cell in x = 0 y = 0 must equal the value of the player token wit" +
                    "h id = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.And("The value of the cell in x = 1 y = 1 must equal the value of the player token wit" +
                    "h id = 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1 and make a st" +
            "ep in cell x = 2 y = 2")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("0")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("0")]
        [NUnit.Framework.CategoryAttribute("and")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("1")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("1")]
        [NUnit.Framework.CategoryAttribute("and")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("step")]
        [NUnit.Framework.CategoryAttribute("in")]
        [NUnit.Framework.CategoryAttribute("cell")]
        [NUnit.Framework.CategoryAttribute("x")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("2")]
        [NUnit.Framework.CategoryAttribute("y")]
        [NUnit.Framework.CategoryAttribute("=")]
        [NUnit.Framework.CategoryAttribute("2")]
        public virtual void MakeAStepInCellX0Y0AndMakeAStepInCellX1Y1AndMakeAStepInCellX2Y2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1 and make a st" +
                    "ep in cell x = 2 y = 2", new string[] {
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "0",
                        "y",
                        "=",
                        "0",
                        "and",
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "1",
                        "y",
                        "=",
                        "1",
                        "and",
                        "make",
                        "a",
                        "step",
                        "in",
                        "cell",
                        "x",
                        "=",
                        "2",
                        "y",
                        "=",
                        "2"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I have a game engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.When("I create game place size 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("I add a player with parameters (name = \"player1\" token = \"X\" id = 1) to the game " +
                    "engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I add a player with parameters (name = \"player2\" token = \"Y\" id = 2) to the game " +
                    "engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I make a step in cell x = 0 y = 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I make a step in cell x = 1 y = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I make a step in cell x = 2 y = 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("The value of the cell in x = 0 y = 0 must equal the value of the player token wit" +
                    "h id = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("The value of the cell in x = 1 y = 1 must equal the value of the player token wit" +
                    "h id = 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("The value of the cell in x = 2 y = 2 must equal the value of the player token wit" +
                    "h id = 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
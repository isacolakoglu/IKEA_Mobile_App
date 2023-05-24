using Microsoft.VisualStudio.TestTools.UnitTesting;
using IKEAMobil.Models;
using IKEAMobil;
using System;

namespace IKEAMobil.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MustPass()
        {
            int fred = 1;
            int ethel = 1;
            Assert.AreEqual(fred, ethel);
        }

        [TestMethod]
        public void WhenProjectStartedIsActive()
        {
            Project project = new Project();
            project.Start();
            Assert.IsTrue(project.IsActive);
        }

        [TestMethod]
        public void ProjectHasDuration()
        {
            DateTime startTime = DateTime.Now;

            var project = new Project();
            project.Start(startTime);
            project.End(startTime.AddSeconds(60));
            Assert.AreEqual(60, project.Duration);
        }
        
        [TestMethod]
        public void ProjectCanStartAndStopAndHasDuration()
        {
            DateTime startTime = DateTime.Now;

            var project = new Project();
            project.Start(startTime);
            project.End(startTime.AddSeconds(60)); //60
            project.Start(startTime.AddSeconds(120));
            project.End(startTime.AddSeconds(240)); //120
            project.Start(startTime.AddSeconds(360));
            project.End(startTime.AddSeconds(720));

            Assert.AreEqual(60+120+360, project.Duration);
        }
    }
}

using System;
using _03_KomodoInsurance_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_KomodoInsurance_Test
{
    [TestClass]
    public class BadgeInfoTests
    {
        [TestMethod]
        public void SetBadge_ShouldSetCorrectInt()
        {
            BadgeInfo badge = new BadgeInfo();

            badge.BadgeID = 12345;

            int expected = 12345;
            int actual = badge.BadgeID;

            Assert.AreEqual(expected, actual);

        }
    }
}

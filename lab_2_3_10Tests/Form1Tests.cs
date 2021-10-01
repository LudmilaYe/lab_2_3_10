using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_2_3_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3_10.Tests {
  [TestClass()]
  public class Form1Tests {
    [TestMethod()]
    public void GetWordsFromSentenceTest1() {
      CollectionAssert.AreEqual(new string[] { "наша", "таня", "громко", "плачет" }, Form1.GetWordsFromSentence("Наша Таня громко плачет:"));
    }
    [TestMethod()]
    public void GetWordsFromSentenceTest2() {
      CollectionAssert.AreEqual(new string[] { "уронила", "в", "речку", "мячик" }, Form1.GetWordsFromSentence("Уронила:;; в речку мячик.    ,,,:"));
    }
    [TestMethod()]
    public void GetWordsFromSentenceTest3() {
      CollectionAssert.AreEqual(new string[] { "речка", "гречка" }, Form1.GetWordsFromSentence("РЕЧКА ГРЕчкА реЧКА гречка"));
    }
  }
}
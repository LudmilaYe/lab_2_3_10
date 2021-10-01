using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_3_10 {
  public partial class Form1 : Form {
    public Form1() { // при запуске программы
      InitializeComponent();

      // подстановка прошлых данных
      sentence1.Text = Properties.Settings.Default.sentence1Saved;
      sentence2.Text = Properties.Settings.Default.sentence2Saved;

      // обрабатываем сохранённое
      SearchWords();
    }
    public static string[] GetWordsFromSentence(string sentence) { // логика получения обработанных слов из строки
      List<string> outWords = new List<string>(); // массив уникальных слов

      // добавляем в outWords все отдельные слова
      foreach (string w in sentence.Split()) { // перебор всех слов
        string newW = w.ToLower(); // делаем мелкими буквами

        // удаляем спецсимволы , . ; :
        foreach (char c in new char[] { ',', '.', ';', ':' })
          newW = newW.Replace(c.ToString(), "");

        // добавление слова в массив, если ещё не встречалось:
        if (!outWords.Contains(newW) && newW != "-" && newW != "")
          outWords.Add(newW);
      }

      return outWords.ToArray(); // вывод полученных слов
    }
    private void SearchWords() { // логика нахождения одинаковых слов
      string[] firstWords = GetWordsFromSentence(sentence1.Text); // получаем слова первого предложения
      string[] secondWords = GetWordsFromSentence(sentence2.Text); // получаем слова второго предложения

      List<string> doublesWords = new List<string>(); // динамический массив слов, содержащихся в обоих предложениях
      List<string> singlesWords = new List<string>(); // динамический массив слов, содержащихся только в первом предложении

      foreach (string w in firstWords) { // перебор всех слов первого предложения
        if (secondWords.Contains(w)) // содержится в обоих
          doublesWords.Add(w);
        else // не содержится во втором
          singlesWords.Add(w);
      }

      // выводим слова на форму:
      doubles.Text = string.Join(" ", doublesWords);
      singles.Text = string.Join(" ", singlesWords);

      // сохраняем ввод в память для след. запуска:
      Properties.Settings.Default.sentence1Saved = sentence1.Text;
      Properties.Settings.Default.sentence2Saved = sentence2.Text;
      Properties.Settings.Default.Save();
    }
    private void InputChanged(object sender, KeyEventArgs e) { // что-то введено
      SearchWords();
    }
    private void ShowTask(object sender, EventArgs e) { // показать задание
      MessageBox.Show("Даны два предложения. Для каждого слова первого предложения определить, входит ли оно во второе предложение. Повторяющиеся слова первого предложения не рассматривать.");
    }
    private void ClearInput(object sender, EventArgs e) { // очистка полей ввода
      sentence1.Text = "";
      sentence2.Text = "";
      SearchWords();
    }
  }
}

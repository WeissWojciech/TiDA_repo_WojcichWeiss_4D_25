using Projekt01UI.Core.Services;
using Projekt01UI.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt01UI.Presenters
{
    internal class TextAnalyzerDataPresenter
    {
        private TextBox _tb_Length;
        private TextBox _tb_Letters;
        private TextBox _tb_Digits;
        private TextBox _tb_Special;
        private TextBox _tb_Time;

        private ITextAnalyzerService _textAnalyzerService;

        public TextAnalyzerDataPresenter(TextBox tb_Length, TextBox tb_Letters, TextBox tb_Digits,
            TextBox tb_Special, TextBox tb_Time)
        {

            _tb_Length = tb_Length;
            _tb_Letters = tb_Letters;
            _tb_Digits = tb_Digits;
            _tb_Special = tb_Special;
            _tb_Time = tb_Time;

            _textAnalyzerService = new TextAnalyzerService();
        }

        public void PerformTextAnalysis(string text)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var result = _textAnalyzerService.PerformAnalysis(text);
            sw.Stop();

            _tb_Length.Text = result.TextLength.ToString();
            _tb_Letters.Text = result.ContainsLetters ? "TAK" : "NIE";
            _tb_Digits.Text = result.ContainsDigits ? "TAK" : "NIE";
            _tb_Special.Text = result.ContainsSpecial ? "TAK" : "NIE";
            _tb_Time.Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}

using Projekt01UI.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt01UI.Shared.Interfaces
{
    public interface ITextAnalyzerService
    {
        TextAnalyzeResult PerformAnalysis(string text);
    }
}

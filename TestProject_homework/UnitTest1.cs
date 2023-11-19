using Projekt01UI.Core.Services;
using Projekt01UI.Shared.Entities;

namespace Projekt01UI.Core.Tests
{
    public class TextAnalyzerServiceTests
    {
        [Fact]
        public void PerformAnalysis_ReturnsCorrectResults1()
        {
            // Arrange
            string text = "Hello 123!";
            var textAnalyzerService = new TextAnalyzerService();

            // Act
            TextAnalyzeResult result = textAnalyzerService.PerformAnalysis(text);

            // Assert
            Assert.Equal(text.Length, result.TextLength);
            Assert.True(result.ContainsLetters);
            Assert.True(result.ContainsDigits);
            Assert.True(result.ContainsSpecial);
        }

        [Fact]
        public void PerformAnalysis_ReturnsCorrectResults2()
        {
            // Arrange
            string text = "Hello153";
            var textAnalyzerService = new TextAnalyzerService();

            // Act
            TextAnalyzeResult result = textAnalyzerService.PerformAnalysis(text);

            // Assert
            Assert.Equal(text.Length, result.TextLength);
            Assert.True(result.ContainsLetters);
            Assert.True(result.ContainsDigits);
            Assert.True(result.ContainsSpecial);
        }

        [Fact]
        public void PerformAnalysis_ReturnsCorrectResults3()
        {
            // Arrange
            string text = "Hello!";
            var textAnalyzerService = new TextAnalyzerService();

            // Act
            TextAnalyzeResult result = textAnalyzerService.PerformAnalysis(text);

            // Assert
            Assert.Equal(text.Length, result.TextLength);
            Assert.True(result.ContainsLetters);
            Assert.True(result.ContainsDigits);
            Assert.True(result.ContainsSpecial);
        }
    }
}
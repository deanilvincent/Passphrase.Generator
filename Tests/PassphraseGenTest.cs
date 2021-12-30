using System;
using Xunit;

namespace PassphraseGenerator.Tests
{
    public class PassphraseGenTest
    {
        [Fact]
        public void Create_CheckParameterIfEmpty_ReturnArgumentNullException()
        {
            var result = Assert.Throws<ArgumentNullException>(() => PassphraseGenerator.Create(null));

            Assert.IsType<ArgumentNullException>(result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        public void Create_GivenLength_ReturnPassphraseLength(int length)
        {
            var option = new Option { Length = length };
            var result = PassphraseGenerator.Create(option);

            Assert.Equal(length, result.Count);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        public void Create_GivenLength_ReturnTrueIfPassphraseMatch(int length)
        {
            var option = new Option { Length = length };
            var result = PassphraseGenerator.Create(option);

            var checkIfAllValid = true;
            foreach (var word in result)
            {
                if (option.StartsWith != null)
                {
                    if (!word.StartsWith((char)option.StartsWith))
                    {
                        checkIfAllValid = false;
                        break;
                    }
                }
            }

            Assert.True(checkIfAllValid);
        }

        [Theory]
        [InlineData(5, 'a')]
        [InlineData(10, 'b')]
        [InlineData(15, 'c')]
        [InlineData(20, 'd')]
        public void Create_GivenLengthAndLetterThatStartsWith_ReturnPassphraseByStartsWith(int length, char startsWith)
        {
            var option = new Option { Length = length, StartsWith = startsWith };
            var result = PassphraseGenerator.Create(option);

            var checkIfAllValid = true;
            foreach (var word in result)
            {
                if (option.StartsWith != null)
                {
                    if (!word.StartsWith((char)option.StartsWith))
                    {
                        checkIfAllValid = false;
                        break;
                    }
                }
            }

            Assert.True(checkIfAllValid);
        }

        [Theory]
        [InlineData(5, 'a')]
        [InlineData(10, 'b')]
        [InlineData(15, 'c')]
        [InlineData(20, 'd')]
        public void Create_GivenLengthAndLetterThatStartsWith_ReturnPassphraseLength(int length, char startsWith)
        {
            var option = new Option { Length = length, StartsWith = startsWith };
            var result = PassphraseGenerator.Create(option);

            Assert.Equal(length, result.Count);
        }
    }
}
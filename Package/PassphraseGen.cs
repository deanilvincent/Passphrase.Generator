using Newtonsoft.Json;

namespace PassphraseGenerator
{
    public static class PassphraseGenerator
    {
        public static List<string> Create(Option option)
        {
            if (option == null) throw new ArgumentNullException();

            var passphrase = new List<string>();
            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), @"words.json"));
            var words = JsonConvert.DeserializeObject<List<string>>(json);

            if (words != null && words.Count > 0)
            {
                if (option.StartsWith != null)
                {
                    var startsWith = (char)option.StartsWith;
                    if (char.IsLetter(startsWith))
                    {
                        option.StartsWith = char.ToLower((char)option.StartsWith);
                        words = words.Where(x => x.ToLower().StartsWith(startsWith)).ToList();
                    }
                }

                for (int i = 0; i < option.Length; i++)
                {
                    var random = new Random();
                    var index = random.Next(words.Count);
                    passphrase.Add(words[index]);
                }
            }

            return passphrase;
        }
    }
}
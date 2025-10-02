using Microsoft.EntityFrameworkCore;
using Wordle.Data;

namespace Wordle.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WordleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WordleContext>>()))
            {
                // Look for any movies.
                if (context.WordModel.Any())
                {
                    return;   // DB has been seeded
                }
                context.WordModel.AddRange(
                    new WordModel { Letters = "pizza", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "grape", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "apple", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "peach", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "mango", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "lemon", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "melon", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "tiger", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "zebra", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "berry", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "chair", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "table", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "plant", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "water", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "earth", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "flame", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "stone", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "cloud", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "mouse", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "horse", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "snake", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "shark", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "whale", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "eagle", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "candy", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "sugar", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "spice", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "honey", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "bread", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "cheer", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "green", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "black", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "white", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "light", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "night", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "dream", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "magic", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "sword", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
                    new WordModel { Letters = "giant", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "pearl", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "melon", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "olive", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "mints", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "syrup", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "otter", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "koala", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "beast", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "crowd", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "swans", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "shelf", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "vasey", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "plate", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "bench", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "brush", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "duneh", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "bloom", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "ridge", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "fjord", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "cliff", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "ivory", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "peach", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "tealr", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "ivory", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "maron", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "happy", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "angry", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "gloom", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "pride", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "frown", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "magic", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "witch", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "sword", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "spell", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "dragon", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "laser", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "robot", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "fiber", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "cable", Length = 5, Created = DateTime.Now, TimesGuessed = 0 },
    new WordModel { Letters = "chipr", Length = 5, Created = DateTime.Now, TimesGuessed = 0 }
                );
                context.SaveChanges();
            }
        }
    }
}

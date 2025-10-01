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
                    new WordModel
                    {
                        Letters = "pizza",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "grape",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "apple",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "peach",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "mango",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "lemon",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "melon",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "tiger",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "zebra",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    },
                    new WordModel
                    {
                        Letters = "berry",
                        Length = 5,
                        Created = DateTime.Now,
                        TimesGuessed = 0,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

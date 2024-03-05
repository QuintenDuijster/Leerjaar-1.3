using Microsoft.Data.Sqlite;
using newssite.Models;
using System.Data;
namespace newssite.DbData
{
    public class NewsDataContext
    {
        public string DbPath { get; }

        public NewsDataContext()
        {
            string location = typeof(NewsDataContext).Assembly.Location;
            string folder = new FileInfo(location).Directory.FullName;
            DbPath = Path.Join(folder, "newssite.db");

            /*
            if (CreateDatabaseIfNotExists())
            {

                AddNews(newsItem);

            }
            */
            NewsItem newsItem = new NewsItem()
            {
                Title = "Initeel bericht",
                Content = "Initeel bericht werdt gepost om: ",
                ImageUrl = "img/newsitem.PNG"
            };
            AddNews(newsItem);
        }

        private bool CreateDatabaseIfNotExists()
        {
            if (File.Exists(DbPath) == false)
            {
                using (SqliteConnection connection = new SqliteConnection("Data source=" + DbPath))
                {
                    connection.Open();

                    SqliteCommand command = connection.CreateCommand();
                    command.CommandText =
                        @"
                            CREATE TABLE News(
                            id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                            title TEXT NOT NULL,
                            content TEXT NOT NULL,
                            imageUrl TEXT NOT NULL,
                            Timestamp DATATIME DEFAULT CURRENT_TIMESTAMP
                            );
                        ";
                    command.ExecuteNonQuery();
                }
                return true;
            }
            return false;
        }

        public void AddNews(NewsItem item)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + DbPath))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO News (title,content,imageUrl)
                    VALUES (@title, @content, @imageUrl);
                ";

                command.Parameters.Add(new SqliteParameter("@title", item.Title));
                command.Parameters.Add(new SqliteParameter("@content", item.Content));
                command.Parameters.Add(new SqliteParameter("@imageUrl", item.ImageUrl));
                int result = command.ExecuteNonQuery();
            }
        }

        public List<NewsItem> GetNews()
        {
            List<NewsItem> items = new List<NewsItem>();

            using (SqliteConnection connection = new SqliteConnection("Data Source=" + DbPath))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();

                command.CommandText = "SELECT * from News order by Timestamp desc;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NewsItem item = new NewsItem()
                        {
                            Title = reader["title"] as string,
                            Content = reader["content"] as string,
                            ImageUrl = reader["imageUrl"] as string
                        };
                        items.Add(item);
                    }
                }
                return items;
            }
        }
    }
}

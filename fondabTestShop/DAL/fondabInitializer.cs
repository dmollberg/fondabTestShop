using fondabTestShop.Models;
using System;
using System.Data.Entity;

namespace fondabTestShop.DAL
{
    public class fondabInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<fondabContext>
    {
        protected override void Seed(fondabContext context)
        {
                var articles = new Article[]
                    {
                    new Article { ArticleNumber = "123-446", Name = "Zeus", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris.", price = 249  },
                    new Article { ArticleNumber = "333-556", Name = "Aphrodite", Description = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.", price = 745  },
                    new Article { ArticleNumber = "553-526", Name = "Hera", Description = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.", price = 1245  },
                    new Article { ArticleNumber = "177-226", Name = "Artemis", Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", price = 49  },
                    new Article { ArticleNumber = "883-588", Name = "Dionysus", Description = "Et harum quidem rerum facilis est et expedita distinctio.", price = 540  },
                    new Article { ArticleNumber = "121-746", Name = "Hades", Description = "Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus.", price = 295  },
                    };

                context.Articles.AddRange(articles);
                context.SaveChanges();
            }
    }
}
using QuestAspMvc.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace QuestAspMvc.DAL
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            List<Article> articles = new List<Article>
            {
                new Article
                { 
                    Title="Processeur", 
                    Description="Un processeur est un composant présent dans de nombreux dispositifs électroniques qui exécute les instructions machine des programmes informatiques.", 
                    ImageLink="https://www.rue-montgallet.com/actualites/wp-content/uploads/2019/05/Processeur-intel-core-i7.jpg" 
                },
                new Article 
                { 
                    Title="Carte Graphique", 
                    Description="Une carte graphique ou carte vidéo est une carte d'extension d’ordinateur dont le rôle est de produire une image affichable sur un écran.",
                    ImageLink="https://img-19.ccm2.net/mfyvPai4kFK_ksepcmzyaXi5Bt4=/255x/ba2bc9409fd94312b4feeffd7665df43/ccm-faq/8034-carte-graphique-s-.png"
                },
                new Article 
                { 
                    Title="Mémoire vive",
                    Description="La mémoire vive, parfois abrégé avec l'acronyme anglais RAM (Random Access Memory), est la mémoire informatique dans laquelle peuvent être enregistrées les informations traitées par un appareil informatique.",
                    ImageLink="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Elixir_M2U51264DS8HC3G-5T_20060320.jpg/1920px-Elixir_M2U51264DS8HC3G-5T_20060320.jpg"
                }
            };

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
        }
    }
}
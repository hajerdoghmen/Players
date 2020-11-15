using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Repository
{
    public class PlayerRepository
    {
        public List<Player> GetAllPlayer()
        {
            HttpClient client = new HttpClient();
            string content = client.GetStringAsync("https://eurosportdigital.github.io/eurosport-csharp-developer-recruitment/headtohead.json").Result ;
            /// classe HttpClient 3andou barcha methode menhom GetStringAsync wel methode hedhi elle retourne un Task de string 
            /// qui un classe Task <....> 3andha plus prop menhm Resultat eli yraja3li contenu mta3 task eli fel cas hedha de type string

            /// tawa lezmni n7awl content eli heya chaine de caractére sous format json el List<Player>

            PlayersJson result = JsonConvert.DeserializeObject<PlayersJson>(content);
            // var result = JsonConvert.DeserializeObject <type de retour>(les donnes des joueurs qui sont string structuré sous format json);
            // classe JsonConvert 3andou méthode DeserializeObject

            //bech nesta3ml el classe JsonConvert lezmni namespace Newtonsoft.Json ama lmochkla dll mte3ou moch mawjouda fel visuel studio donc lezmni ntélechrgiha
            // Repository => References => clique droite => Pakage Nuget Pakage => Brows => installer
            var x = result.players;
            return x;
        }
    }

    public class PlayersJson
    {
        public List<Player> players { get; set; }
    }
}

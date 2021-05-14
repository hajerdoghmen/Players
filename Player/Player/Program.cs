using Repository;
using UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Resultat;

namespace Player
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ajout de commentaire awdha7
            PlayerUseCase useCase = new PlayerUseCase();

            List<PlayerResultat> result = useCase.GetAll();
            // Manajmch nest3ml console.Writeline direct 3ala liste donc nesta3ml Foreach
            foreach (PlayerResultat item in result)
            //Console.WriteLine(item); Heshi matraj3lich eli west PlayerResultat 
            //traja3 namespace.Type donc lezmni na9rahom bel détails fullName, rank...)
            {
                Console.WriteLine(item.FullName + " " + item.Rank.ToString() + " " + item.Height.ToString());
            }
        }
    }
}

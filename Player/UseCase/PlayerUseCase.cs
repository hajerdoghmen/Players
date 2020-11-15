using System;
using Model;
using Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Resultat;

namespace UseCase
{
    public class PlayerUseCase
    {
        public List<PlayerResultat> GetAll()

        {
            PlayerRepository playerRepository = new PlayerRepository();

            List<Player> playerModel = playerRepository.GetAllPlayer();
            // hedhi men  List<Player> lezmni n7awelha  List<PlayerResultat>
            List<PlayerResultat> r = playerModel.Select(item => new PlayerResultat()
            {
                FullName = item.firstname + " " + item.lastname,
                Rank = item.data.rank,
                Height = item.data.height / 100 // 9samt 3ala 100 bech n7awl mel cm lel m
            }
               ).ToList();

            return r;
        }
    }
}

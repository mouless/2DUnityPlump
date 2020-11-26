using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public static class GameService
    {
        public static System.Random r = new System.Random();
        public static Stack<int> TricksPerRound = new Stack<int>();
        public static int WhoStartsTheGame;

        public static readonly PlayerService _playerService = new PlayerService();
        public static readonly TurnService _turnService = new TurnService();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void OnBeforeSceneLoadRuntimeMethod()
        {
            Debug.Log("Den här metoden körs innan första Scenen är laddad");
        }

        public static void StartGame()
        {
            Debug.Log("GameService.StartGame() is running");

            _turnService.CreateNewRound();
        }
    }
}

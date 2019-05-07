﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
   public class TwentyOne:Game,IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach(Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");
            foreach(Player player in Players)
            {
                int bet =Convert.ToInt32( Console.ReadLine());
                bool sucessfullyBet = player.Bet(bet);
                if (!sucessfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.WriteLine("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJck {0}: wins {1]}:",player.Name,Bets[player]);
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]);

                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("deals has BlackJAck EveryObe losses");
                        foreach(KeyValuePair<Player,int> entry in Bets)
                        {
                            Dealer.Balacne += entry.Value;
                        }
                    }
                }
            }
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your Cards are:");
                    foreach (Card card in Player.Hand)
                    {
                        Console.Write("{0}:",card.ToString());
                    }Console.WriteLine("\n\nHit or Stay");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay"){
                        player.Stay = true;
                        break;
                    }else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balacne += Bets[player];
                        Console.WriteLine("{0} Busted! Ypu lose bet of {1}." +
                            "Your balance is now{2}.", player.Name,Bets[player],player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivePlaying = true;
                        }
                        else
                        {
                            player.isActivePlaying = false;
                        }
                    }
                }
            }
        }
        public override void ListPlayer()
        {
            Console.WriteLine("Welcome to 21 Players");
            base.ListPlayer();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}

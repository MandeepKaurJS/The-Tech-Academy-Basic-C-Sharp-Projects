using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cosino;
using System.Data.SqlClient;

namespace CardsGame
{
    class Program
    {
        
        Player newPlayer = new Player("Mandeep");
        static void Main(string[] args)
        {
            DateTime datetime = new DateTime(1995, 5, 23, 8, 32, 45);

            Console.WriteLine("Welcome to the Grand Hotel and Casino." +
                "Let's start by telling me your name: ");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.WriteLine(exception.Id + "| ");
                    Console.WriteLine(exception.ExceptionType + "| ");
                    Console.WriteLine(exception.ExceptionMessage + "| ");
                    Console.WriteLine(exception.TimeStamp + "| ");
                    Console.WriteLine();

                }
                Console.ReadLine();
                return;
            }
            bool Validanswer = false;
            int bank = 0;
            while (!Validanswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                Validanswer = int.TryParse(Console.ReadLine(), out bank);
                if (!Validanswer) Console.WriteLine("please enter digits only,no decimals");
            }
            //Console.WriteLine("And how much money did you bring today?");
             //bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now? "+playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                
                
                Player player = new Player(playerName,bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\VrinMan Dulay\Documents\test.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOne();
                game += player;
                player.isActivePlaying = true;
                while(player.isActivePlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        updateDBWtihException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error Occured. Please Contact to your system administrator");
                        updateDBWtihException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
            //Deck deck = new Deck();
            //deck.Shuffle(3);
            //foreach(Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

        }
        private static void updateDBWtihException(Exception ex)
        {
            string connectionstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                    Integrated Security=True;Connect Timeout=30;" +
                                    "Encrypt=False;TrustServerCertificate=False;" +
                                    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string querystring = @"INSERT INTO Exception(ExceptionType,ExceptionMessage,TimeStamp)values
                                (@ExceptionType,@ExceptionMessage,@TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(querystring, connection);
                command.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime);
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();


            }

        }
       private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                    Integrated Security=True;Connect Timeout=30;" +
                                    "Encrypt=False;TrustServerCertificate=False;" +
                                    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string querystring = @"select Id,ExceptionType,ExceptionMessage,Timestamp from Exception";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(querystring, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = (reader["ExceptionType"].ToString());
                    exception.ExceptionMessage = (reader["ExceptionMessage"].ToString());
                    exception.TimeStamp =Convert.ToDateTime (reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}

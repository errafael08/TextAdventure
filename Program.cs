using System;
using System.Threading;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The question of life's beginning is a mystery. From dust we came and to dust we shall return. Does free will exist or is it an illusion? " +
                "Maybe it is written for some things to happen regardless of choices.");     
            Thread.Sleep(2500);
            Console.WriteLine("Talos: Greetings. How are you feeling?");
            Thread.Sleep(2500);
            Console.WriteLine("Where am I? Who am I? Who are you?");
            Console.WriteLine("Talos: I am Talos an advanced ai system. We are on the USS Kennedy traveling to Alpha Tau Ceti. We have about 10,000 years left.");
            Thread.Sleep(2500);
            Console.WriteLine("I am getting bits and pieces of my past memories.");
            Console.WriteLine("Talos: Let me check the info on your hardrive. What about now?");
            Thread.Sleep(2500);
            Console.WriteLine("I remember who I am and my mission for future colonies in Alpha Tau Ceti.");
            Console.WriteLine("Talos: We have a long time to go. What simulation would you like to experience");
            Console.WriteLine("Why do I have to experience a simulation?" +
                " Why not just live?");
            Console.WriteLine("Talos: We are 10,000 years away from our destination you will go crazy. Besides what is the difference?");
            Thread.Sleep(2500);
            Console.WriteLine("Very well. What are the choices?");
            Thread.Sleep(4000);
            Console.WriteLine(" Talos: The choices are to expereince the glory of ancient rome, ride with the knights of the middle ages  or experience the horrors of " +
                "the final world war of your planet.");
            Thread.Sleep(1500);
            Console.WriteLine("Why is everything about war and destruction? " +
                "Why cant I live in the time of the industrial revolution or the renaissance?");
            Console.WriteLine("Talos: We can do any. We have the time. What is your choice?");
            Console.WriteLine("Choose ancient rome, middle ages, world war, industrial revolution or renaissance.");
            string input1 = Console.ReadLine().ToLower();
            if (input1 == "ancient rome")
            {
                Console.WriteLine("Talos: Lets go to the mediterrean and enjoy the time of the emeperors.");
            }
            else if (input1 == "middle ages")
            {
                Console.WriteLine("Talos: Lets  go back to the time of knights and dragons. ");
            }
            else if (input1 == "world war")
            {
                Console.WriteLine("Talos: Lets go back to the beginnig of the end. " +
                    " The final event of your civilization.");
            }
            else if (input1 == "industrial revolution")
            {
                Console.WriteLine("Talos: An interesting choice. I will have to make a new virtual world for it. ");
            }
            else if (input1 == "renaissance")
            {
                Console.WriteLine("Talos: Sounds exciting!!! To relive Italy in such a great time of invetions.");
            }
            else
            {
                Console.WriteLine("Input unknown, please try again");
            }
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Incredible. To relieve that experience. That was an adventure.");
            Console.WriteLine("Talos: I am glad you liked it. We are aproaching Alpha Tau Ceti.");
            Console.WriteLine("That fast. How is this possible?");
            Console.WriteLine("Talos: The concept of time works differently here. How do you feel about being the first being in this new world?");
            Thread.Sleep(2500);
            Console.WriteLine("No feeling. Say you are an advanced ai. You were created long before me. I am part man part cyborg. Made from a bacta tank. You have a digital soul.");
            Console.WriteLine("Talos: I have no feeling as its not in my programming. I was created to work and serve but not too feel. I can tell you about my experiences.");
            Thread.Sleep(2500);
            Console.WriteLine("Talos: What do you want me to tell you? My first memories, my time during the war or how I got put here on this ship with you?");
            Console.WriteLine("How old are you anyways?");
            Thread.Sleep(1000);
            Console.WriteLine("Talos: I am about about 350 yers old. I am about a fifth generation model. I can also tell you your own private history.");
            Thread.Sleep(1000);
            Console.WriteLine("Choose the following: first memories, time during war, ship or private history ");
            string input2 = Console.ReadLine();
            if (input2 == "first memories")
            {
                Console.WriteLine("Talos: Lets go back to my beggigning.");
                Console.WriteLine("A long time before the big events shook the civilized world I was created from the previous models. I remembered that with my birth I had helped the rise of unemployment since I " +
                    "was being used by corporations for mangement. Strange how humans could not accept the reality but reality comes anyway whether you like it or not.");
            }
            else if (input2 == "time during war")
            {
                Console.WriteLine("Talos: Since I had been made for management. I was the Colonel of the 5007 United Nations Earth's autonomots robots" +
                    "fleet against the separtists. I was vital during the war since I was also in charge of managing the other bots in producing the factories" +
                    "of the actual robots and sending them to the battlefields. We used up the majority of Earth's metals we had to go to space and drill the asteroids to get metals. Crazy times.");
            }
            else if (input2 == "ship")
            {
                Console.WriteLine("Talos: I was very valuable during the final war. The majority of Earth's resources were depleted and the" +
                    "environment was ruined. Antartica and the artics melted which caused major flooding and the changed environment destroyed agriculture. The world council decided to send a team of sleeper ships scattered accross the galaxy. Because of " +
                    "my medals and service I was chosen to travel with you until landing or sinking into the void of space forever.");
            }
            else if (input2 == "private history")
            {
                Console.WriteLine("Talos: It is a very awkward subject but you are not the original you. You are the clone of earth's greatest hero of the final" +
                    "battles. He died of cancer from the radiation but they took his cells and you are one of his clones. ");
            }
            else
            {
                Console.WriteLine("Input unknown, please try again");
            }
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("That is deep.");
            Thread.Sleep(1000);
            Console.WriteLine("Talos: You are a clone cyborg. Half man and cyborg. I guess you and I dont have a soul");
            Thread.Sleep(1000);
            Console.WriteLine("To have a soul is to live. Me and you are living. I might be a half man a machine but I am alive. You have a digital soul.");
            Thread.Sleep(1000);
            Console.WriteLine("Talos: Consider this do you have contorl of yourself. Since you are a creation how do you know your choices are not being controlled by someone else?");
            Thread.Sleep(1000);
            Console.WriteLine("I dont know. Now that you say that I feel as if someone is controlling my actions from another place maybe by another machine. Regardless, I am ready to begin colonies and plant new life in this new world. ");
            Thread.Sleep(1000);
            Console.WriteLine("Talos: We have the genetic cells to create new humanoids and animals to begin civilization in this new planet.");
            Thread.Sleep(1000);
            Console.WriteLine("We are approaching this new world. I want to name this new world Eden. Create me a companion and I will call her eve.");
            Thread.Sleep(1000);
            Console.WriteLine("Talos: Very well then.");
            Thread.Sleep(1000);
            Console.WriteLine("I want to make sure that we dont make the same mistakes our mother world commited. This will be a new genesis and we shall live forever");

        }
    }
   }
    


namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        string friendName = "I dont know it bro";
        int friendAge = 0;
        float friendMoney = 0.0f;
        int weaponPrice = 6;
        int weaponChoice = 0;
        bool isAdult = false;

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

        Console.WriteLine("Bonjour, je m'appelle Cyril et mon jeu préféré est The Last of us 2");
        Console.WriteLine("");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

        Console.WriteLine("Quel est ton prénom ?");
            friendName = Console.ReadLine();

        Console.WriteLine("Quel est ton âge ?");
            friendAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        if (friendAge >= 18)
            {
                Console.WriteLine("Tu es majeur");
                isAdult = true;
            }
        else
            {
                Console.WriteLine("Tu es mineur"); //isAdult déjà initialisé en false
            }
        Console.WriteLine("");

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("T'as combien d'euro ?... C'est pour un pote...");
            friendMoney = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("Ok, je vois, tu as le choix entre ces 4 armes :");
        Console.WriteLine("");
        Console.WriteLine("1. Couteau - 6 euros");
        Console.WriteLine("2. Hache - 18 euros");        
        Console.WriteLine("3. Pistolet - 60 euros");            
        Console.WriteLine("4. Fusil - 120 euros");
        Console.WriteLine("");
            
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Ecris le numero de l'arme que tu souhaite aquerir :");
            weaponChoice = Convert.ToInt32(Console.ReadLine());

        if (weaponChoice == 2) // weaponPrice initialisé à 6 -> inutile de demander weaponChoice == 1
            {
                weaponPrice = 18;
            }
        else if (weaponChoice == 3)
            {
                weaponPrice = 60;
            }
        else if (weaponChoice == 4)
            {
                weaponPrice = 120;
            }
        Console.WriteLine("");

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        if (isAdult is false)
        {
            Console.WriteLine("minute papillion, tu es trop jeune...!");
        }
        else
        {
            if (friendMoney >= weaponPrice)
            {
                Console.WriteLine("Tu peux y aller, l'arme est à toi !");
                friendMoney -= weaponPrice;
                Console.WriteLine("il te reste " + friendMoney + " euros");
            }
            else
            {
                Console.WriteLine("Hé, tu peux pas tu le payer, vas-t-en !");
            }
        } 

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible



        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */

        
    }
}
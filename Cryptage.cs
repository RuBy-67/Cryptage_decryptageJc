using System;

class cryptage
{
    static void Main()
    {

        string prog_Cryptage;
        string prog_Decryptage;
        int entre_User;
        string phrase;
        int decallage;
        string newtext;

        Console.WriteLine("Bienvenue dans l'outils de Cryptage et de Decryptage de Jules César !\n Quels outils voulez vous utilisez ?\n- Cryptage ? Taper 1\n- Decryptage ? Taper 2");

        entre_User = int.Parse(Console.ReadLine());

        if (entre_User == 1)
        {
            Console.WriteLine("Entrer votre chaine de caractère à crypter");
            phrase = Console.ReadLine();
            newtext = harmonisation(phrase);
            

            Console.WriteLine("quel décalage voulez-vous ?");
            decallage = int.Parse(Console.ReadLine());


            prog_Cryptage = progCryptage(newtext, decallage);

             Console.WriteLine(prog_Cryptage);
        }



        /*if (entre_User == 2)
        {
            Console.WriteLine("Entrer votre chaine de caractère à decrypter");
            phrase = Console.ReadLine();
            Console.WriteLine("De combien est votre decallage ?");
            decallage = int.Parse(Console.ReadLine());
  
            prog_Decryptage = progDecryptage(phrase , decallage);
        }*/

        else
            Console.WriteLine("Merci d'entrer un nombre correct !");

    }



    public static string harmonisation(string texte)
    {

        string chaine = "";
        int boucle;

        boucle = texte.Length;

        for (int i = 0; i < boucle; i++)
        {

            if (((int)texte[i] >= (int)'A' && (int)texte[i] <= (int)'Z') || ((int)texte[i] >= (int)'a' && (int)texte[i] <= (int)'z'))
            {
                if ((int)texte[i] >= (int)'a' && (int)texte[i] <= (int)'z')
                {

                    chaine = chaine + texte[i];
                }

                else
                {

                    chaine = chaine + (char)((int)(texte[i]) + ((int)'a' - (int)'A'));
                }

            }
        }
        return chaine;


    }

    public static string progCryptage(string texte, int decallage)
    {

        char[] chars = texte.ToCharArray();
        for (int i = 0; i < texte.Length; i++)
        {
            if ('a' <= chars[i] && chars[i] <= 'z')
            {
                chars[i] = (char)(int)(((chars[i] - 'a') + decallage) + 'a');
                if (chars[i] > 'z')
                    chars[i] = (char)(int)((chars[i] - 'z') + 'a' - 1);

            }

            else if ('0' <= chars[i] && chars[i] <= '9')
            {
                chars[i] = (char)(int)(((chars[i] - '0') + decallage) + '0');
                if (chars[i] > '9')
                    chars[i] = (char)(int)((chars[i] - '9') + '0' - 1);


            }
        }
        return new String(chars);



    }
    /* public static string progDecryptage(string texte, int decallage){

     return new String(chars);


     }*/
}
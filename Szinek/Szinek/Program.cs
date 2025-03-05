namespace Szinek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szinek = { "piros", "kék", "sárga", "lila", "zöld", "fekete", "fehér", "narancs" };
            string[] nevek = { "János", "Ferenc", "András", "István", "Péter", "Zoltán", "Ákos", "Álmos", "Botond", "Krisztián", "Áron", "Kornél", "Mór", "Roland", "Máté", "Mihály", "József", "Attila", "Sándor", "Dominik", "Abélia", "Abiáta", "Abigél", "Ada", "Adala", "Adalberta", "Adalbertina", "Adaléna", "Adalind", "Adamina", "Adaora", "Adél", "Adela", "Adéla", "Adelaida", "Adelgund", "Adelgunda", "Adelheid", "Adélia", "Adelin", "Adelina", "Adelinda", "Adeliz", "Adeliza", "Adema", "Adeodáta", "Adina", "Admira", "Adolfina", "Adonika", "Adóra", "Adria", "Adriána", "Adrianna", "Adrienn", "Adrienna", "Adrina", "Áfonya", "Áfra", "Afrika", "Afrodita", "Afrodité", "Afszana", "Agapi", "Agáta", "Ági", "Aglája", "Aglent", "Agnabella", "Agnella", "Ágnes", "Agnéta", "Ágosta", "Ágota", "Agrippína", "Aida", "Aina", "Ainó", "Aira", "Aisa", "Aisah", "Ajana", "Ajándék", "Ajla", "Ájlá", "Ájlin", "Ajna", "Ajnácska", "Ajnó", "Ajra", "Ajsa", "Ájszel", "Ajtonka", "Akaiéna", "Akilina", "Alamea", "Alaméa", "Alana", "Alba", "Alberta", "Albertin", "Albertina", "Albina", "Alda", "Áldáska", "Aldea", "Álea", "Aléna", "Aleszja", "Alesszia", "Alett", "Aletta", "Alexa", "Alexandra", "Alexandrin", "Alexandrina", "Alexia", "Alfonza", "Alfonzin", "Alfonzina", "Alfréda", "Alia", "Aliana", "Alianna", "Alica", "Alicia", "Alícia", "Alida", "Alina", "Alinda", "Alinka", "Alirán", "Alisa", "Aliszia", "Alissza", "Alita", "Alitta", "Aliz", "Alíz", "Aliza", "Alizé", "Alízia", "Allegra", "Alma", "Almanda", "Almira", "Almiréna", "Almitra", "Aloé", "Alojzia", "Aloma", "Alóma", "Altea", "Alvina", "Ama", "Amábel", "Amadea", "Amadil", "Amaja", "Amál", "Amália", "Amana", "Amanda", "Amandina", "Amara", "Amarant", "Amaranta", "Amarill", "Amarilla", "Amarillisz", "Amáta", "Amázia", "Ambrózia", "Amelda", "Ameli", "Amélia", "Amelita", "Ametiszt", "Amidala", "Amika", "Amilla", "Amina", "Ámina", "Aminta", "Amira", "Amrita", "Anabel", "Anabell", "Anabella", "Anada", "Anahita", "Anaisz", "Anaszta", "Anasztázia", "Anatólia", "Ancilla", "Ancsa", "Anda", "Andelin", "Andelina", "Andi", "Andrea", "Andreina", "Andrina", "Androméda", "Anélia", "Anelíz", "Anelma", "Anéta", "Anett", "Anetta", "Ánfissza", "Angéla", "Angélia", "Angelika", "Angelina", "Angella", "Angyal", "Angyalka", "Ani", "Ania", "Anica", "Anicéta", "Aniella", "Anika", "Anikó", "Anilla", "Anima", "Anina", "Anisza", "Aniszia", "Anissza", "Anita", "Anitra", "Anízia", "Ánizs", "Anka", "Ankisza", "Anna", "Annabel", "Annabell", "Annabella", "Annabori", "Annadóra", "Annadorka", "Annakarina", "Annakata", "Annalea", "Annaleila", "Annaléna", "Annalili", "Annalilla", "Annalina", "Annaliza", "Annalujza", "Annamari", "Annamária", "Annamira", "Annamíra", "Annaregina", "Annaréka", "Annarita", "Annaróza", "Annarózsa", "Annasára", "Annaszofi", "Annaszófia", "Annavera", "Annavirág", "Annazsófia", "Anneke", "Annelin", "Anni", "Annika", "Annunciáta", "Anriett", "Antea", "Antigoné", "Antoaneta", "Antoanett", "Antonella", "Antónia", "Antoniett", "Antonietta", "Anuk", "Anzelma", "Ánya", "Apol", "Apolka", "Apollinária", "Apollónia", "Aporka", "Appia", "Ápril", "Áprilka", "Arabella", "Aranka", "Arany", "Aranyka", "Aranyos", "Arenta", "Ari", "Aria", "Ariadna", "Ariadné", "Ariana", "Arianna", "Ariéla", "Ariella", "Arienn", "Arietta", "Arika", "Arikán", "Arina", "Arinka", "Arisza", "Arita", "Arlena", "Arlett", "Armanda", "Armandina", "Armella", "Armida", "Armilla", "Ármina", "Arna", "Árnika", "Arona", "Árpádina", "Artemisz", "Artemízia", "Artiana", "Árvácska", "Árven", "Arzénia", "Asella", "Asma", "Aszenát", "Ászja", "Aszpázia", "Asszunta", "Asztéria", "Asztra", "Asztrea", "Asztrid", "Asztrida", "Atala", "Atalanta", "Atália", "Atanázia", "Atára", "Aténa", "Aténé", "Atika", "Atina", "Auguszta", "Augusztina", "Aura", "Aurea", "Aurélia", "Aurora", "Auróra", "Avani", "Avarka", "Aviána", "Avitál", "Azala", "Azálea", "Aziza", "Azra", "Azucséna", "Azura", "Azurea", "Babarózsa", "Babér", "Babett", "Babetta", "Babiána", "Babita", "Bagita", "Bahar", "Balbina", "Balda", "Balzsa", "Balzsam", "Banánvirág", "Bara", "Barack", "Baranka", "Barbara", "Barbarella", "Barbi", "Barbel", "Barka", "Bársony", "Bársonyka", "Baucisz", "Bazilia", "Bea", "Beáta", "Beatricse", "Beatrisz", "Beatrix", "Bebóra", "Béda", "Begónia", "Bejke", "Bekka", "Béke", "Belinda", "Bella", "Bellaróza", "Bellatrix", "Benáta", "Benedetta", "Benedikta", "Beneditta", "Benigna", "Benita", "Benjamina", "Bente", "Bereniké", "Berfin", "Berill" };

            int szinek_szama = szinek.Length;
            int nevek_szama = nevek.Length;

            Console.WriteLine($"Színek száma: {szinek_szama} | Nevek száma: {nevek_szama}");

            for (int i = 0; i < szinek_szama; i++)
            {
                Console.WriteLine( i + " " + szinek[i]);
            }

            int x = 1;
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

        }
    }
}

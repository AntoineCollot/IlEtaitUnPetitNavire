using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NameGenerator {

    static string[] names = new string[] { "Nolan", "Shelby", "Walton", "Jim", "Weldon", "Victor", "Deandre", "Raymond", "Darell", "Dusty", "Hai", "Lance", "Don", "Wilburn", "Samuel", "Jonah", "Walker", "Randell", "Donnell", "Antone", "Miquel", "Gustavo", "Dion", "Max", "Granville", "Leonel", "Erasmo", "Jerald", "Vance", "Bradley", "Lonny", "Israel", "Aaron", "Seth", "Clemente", "Arturo", "Rhett", "Fernando", "Gaston", "Filiberto", "Olin", "Del", "Spencer", "Clifton", "Jayson", "John", "Jon", "Michal", "Emil", "Edmundo",
    "Burl","Avery","Ernesto","Frankie","Salvador","Alex","Oliver","Adalberto","Kip","Stewart","Blair","Raphael","Dominick","Rocky","Arlen","Steve","Abraham","Ethan","Robby","Renato","Elliott","Humberto","Arturo","Romeo","Darron","Augustus","Derek","Wilfred","Blaine","Darrick","Efrain","Bernie","Cleveland","Tyree","Marvin","Dewayne","Dwight","Lindsey","Antonio","Billy","Vern","Amos","Lindsay","Kent","Lupe","Nicky","Austin","Andre","Ian","Archie",
    "Ricky","Leigh","Val","Terrence","Issac","Forest","Jake","Jon","Darell","Alphonso","Tony","Barrett","Wally","Mason","Cesar","Valentin","Horace","Jarvis","Toney","Carlo","Emile","Jeremiah","Markus","Benjamin","Marc","Wes","Morton","Gene","Gavin","Russ","Parker","Stevie","Jefferson","Clay","Milan","Quentin","Mitchell","Bryon","Clemente","Byron","Irving","Porter","Burt","Timothy","Herb","Ryan","Charlie","Reynaldo","Terrance","Ellsworth"};

    public static void FormatString()
    {
        string s = @"";
        string[] array = s.Split(' ','\n');

        string output = "";

        foreach (string str in array)
        {
            if(str.Length>2)
                output += "\"" + str + "\",";
        }

        Debug.Log(output);
    }

    public static string GetRandomName()
    {
        return names[Random.Range(0, names.Length)];
    }
}

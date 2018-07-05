using System.Collections.Generic;
using System;

namespace RPG
{
    public class Ninja : Human{

                public Ninja(string nameVal="", int dexVal = 175) : base(){
                name = nameVal;        
                dexterity = dexVal;       
   
                }
                public void stealHealth(object obj){
                Human enemy = obj as Human;
                System.Console.WriteLine(name + " stole 10 health from " + enemy.name );
                enemy.health -= 10; 
                health +=10;           
                }
                public void get_away(){
                health -= 15;
            }

    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using persistencia.Entities;
using Newtonsoft.Json;

namespace persistencia.Entities
{
    public class Controladores
    {
        List<Team> teams = new List<Team>();
        public Controladores(){
            if(!ExistsFile()){
                CrearFile();
            }
        }    
        public bool ExistsFile(){
            bool isValid=true;
            if (File.Exists("fifawc.json")){
                isValid=true;
            }
            else{
                isValid=false;
            }    
                return isValid;
                
        }
        public void CrearFile{
            if(!ExistsFile()){
                File.Create("fifawc.json");
            }
        }
        public void AddInfo(){
            Team equipo = new Team();
                Console.Write
        }
        
    }
}

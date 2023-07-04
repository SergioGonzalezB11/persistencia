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
            }else{
               /*  using (StreamReader reader = new StreamReader("fifawc.json"){
                    string json = reader.ReadToEnd();
                    this.teams = System.Text.Json.JsonSerializer.Deserialize<List<Team>>(json,new System.Text.Json.JsonSerializer{PropertyNameCaseInsensitive = true}) ?? new List<Team>(teams); */
                }
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
        public void CrearFile(){
            if(!ExistsFile()){
                File.Create("fifawc.json");
            }
        }
        public void AddInfo(){
            Team equipo = new Team();
            Console.WriteLine("Ingrese el Id del equipo: ");
            equipo.IdTeam = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del equipo: ");
            equipo.NameTeam = Console.ReadLine();
            teams.Add(equipo);
            SaveDataFile();
        }
        public void AddPlayerToTeam(string Id){
            bool isAddPlayer = true;
            Team teamToEdit =teams.FirstOrDefault(team => team.Id ?? string.Empty).equals(Id)?? new Team();
            if (teamToEdit != null)
            {
                do{
                    Player players = new Player();
                    do{
                        bool isValidDorsal = false;
                        Console.WriteLine("Ingrese Nro del dorsal");
                        isValidDorsal = (players.IdPlayer ?? string.Empty).Length > 3;
                        if (isValidDorsal){
                            Console.WriteLine("El numero es imposible de imprimir en la camiseta");
                            Console.WriteLine();
                            continue;
                        }

                    }while(GetPlayerCount(teamToEdit,(players.IdPlayer ?? string.Empty));
                }
            }

        }

        public void SaveDataFile(){
            string json =JsonConvert.SerializeObject(teams,Formatting.Indented);
            File.WriteAllText("fifawc.json",json);
        }
        
    }


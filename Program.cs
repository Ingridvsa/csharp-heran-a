using _5.Rpg.Models;

string nome = Console.ReadLine();
int mana = int.Parse(Console.ReadLine());
int danoBase = int.Parse(Console.ReadLine());
      
Dano meuPersonagem = new Dano(nome, mana, danoBase);
      
meuPersonagem.CalcularDano();
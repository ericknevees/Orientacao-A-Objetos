using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia2
{
    public class Segurado
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string CPF { get; set;}
        //O construtor tem o mesmo nome da classe

        //Construtor default (padrão)
         public Segurado(){ 
        
                }
        //Construtor com parâmetro
        //Pesquisa por id
        public Segurado(int id)
        {
            Id = id;
        }
        //Construtor com Sobrecarga (Override)
        //Cadastra incerto no banco
        public Segurado(string nome)
        {
            Nome = nome;
        }
        public Segurado(string cpf, string nome)
        {
            Nome = nome;
            CPF = cpf;
        }
        public Segurado(int id, string cpf, string nome)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            
        }
        public string Teste()
        {
            return "Chegou Aqui";
        }
    }
}

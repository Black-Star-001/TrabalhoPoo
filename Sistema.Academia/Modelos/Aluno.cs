﻿//using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Sistema.Academia.Modelos
{
    public class Aluno
    {
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public int Idade {get; set;}
        public string Sexo {get; set;}
        public string Nascimento {get; set;}

        public override string ToString()
        {
        return $"{Nome}, {Cpf}, {Idade}, {Sexo}, {Nascimento}";
        }
    }



}


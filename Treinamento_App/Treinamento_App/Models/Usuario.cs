using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_App.Models
{
    class Usuario
    {
        private string _Nome;
        private string _Senha;

        public void setNome(string nome)
        {
            this._Nome = nome;
        }

        public string getNome()
        {
            return this._Nome;
        }
        public void setSenha(string nome)
        {
            this._Nome = nome;
        }

        public string getSenha()
        {
            return this._Nome;
        }

    }
}

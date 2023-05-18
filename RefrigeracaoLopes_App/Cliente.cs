using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;



namespace RefrigeracaoLopes_App
{
    internal class Cliente
    {

        public static CultureInfo culture = new CultureInfo("pt-BR");


        private String cpf;
        private String nome;
        private String email;
        private String telefone;
        private String servico;
        private DateTime dataNasc;

       

        private String endereco;
        private int id;

        
        public Cliente(String cpf, String nome, String email, String telefone, String endereco, DateTime dataNasc)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
            this.dataNasc = dataNasc;

        }
        public Cliente() { 
            
        }
        public String getCpf()
        {
            return cpf;
        }
        public String getNome()
        {
            return nome;
        }
        public String getEmail()
        {
            return email;
        }
        public int getId()
        {
            return id;
        }
        public String getEndereco()
        {
            return endereco;
        }
        public String getTelefone()
        {
            return telefone;
        }
        public void setDataNsc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        public DateTime getDataNsc()
        {
            dataNasc.ToString("d", culture);
            return dataNasc;
        }

        public void setCPF(String cpf)
        {
            this.cpf = cpf;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public void setID(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return "NOME: " + getNome() + " - CPF: "+ getCpf() + " - END: " + getEndereco() + " - Nascimento: " + getDataNsc();
        }
        public DialogResult criarClient(String cpf, String nome, String email, String telefone, String endereco)
        {
            //Esse metodo será chamado na area principal
            //Código para pegar dos param's e inserir numa stringSQL e inserir na DB clientes
            //Também nisso pesquisar como pegar o código de êxito do SQL
            //e fazer um operador ternário pro MessageBox

            return MessageBox.Show("Cliente criado com sucesso!");
        }
         
        
    }
}

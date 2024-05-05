

namespace FilaNumerosInteiros
{
    internal class Numero
    {
        int numero;
        Numero proximo;

        public Numero(int numero)
        {
            this.numero = numero;
            this.proximo = null;
            proximo=null;
        }

        public int getNumero() //retornar valor
        {
            return numero;
        }

        public int setNumero() //atribuir valor
        {
            return numero;
        }

        public override string? ToString()
        {
            return numero.ToString();
        }

           
        public void setProx(Numero aux) //set do próximo
        {
            this.proximo = aux;
        }
        public Numero getProx() 
        {
            return this.proximo;
        }
    }
}


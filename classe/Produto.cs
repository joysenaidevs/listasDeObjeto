namespace listasDeObjeto.classe
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Name { get; set; }
        public float Preco{ get; set; }
        
        public Produto(){

        }
        
        public Produto(int  _codigo, string  _nome, float  _preco)
        {
            this.Name = _nome;
            this.Codigo = _codigo;
            this.Preco = _preco;
        }
        
            
        
        
        
        
        
        
        
        
    }
}
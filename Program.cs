 public class libro{
    // Atributos
    private string titulo="";
    private string autor="";
    private int ISBN;
    private int numerodepaginas;
   
   // Metodos        
        public void getlibro(){
            Console.WriteLine(this.titulo);
        }
        public void setlibro(string titulo){
            this.titulo=titulo;
        }
        public void getautor(string autor){
            Console.WriteLine(this.autor);
        }
        public void setautor(string autor){
            this.autor=autor;
        }
        public void getISBN(int ISBN){
            Console.WriteLine(this.ISBN);
        }
        public void setISBN(int ncode){
            this.ISBN=ncode;
        }public int getnumerodepaginas(){
            return this.numerodepaginas;
        }
        public void setnumerdepaginas(int numerodepaginas){
            this.numerodepaginas=numerodepaginas; 
        }

         public void tostring (){
         Console.WriteLine("el libro "+this.titulo+" con ISBN "+this.ISBN+"creado por el autor "+this.numerodepaginas+"paginas");
        }
 }




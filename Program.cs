﻿ public class libro{
    // Declara las variables
    // declara la variable titulo
    private string titulo="";
    //declara la varible autor
    private string autor="";
    //declara la variable ISBN
    private int ISBN;
    //declara la variablenumerodepaginas
    private int numerodepaginas;
   
   //   llama la variable libro     
        public void getlibro(){
            // escribe lo que esta en la variable titulo
            Console.WriteLine(this.titulo);
        }
        // guarda en la variable libro 
        public void setlibro(string titulo){
            this.titulo=titulo;
        }
        //llama la varible autor
        public void getautor(string autor){
            // escribe lo que esta en la varible autor
            Console.WriteLine(this.autor);
        }
        // guarda en la variable autor
        public void setautor(string autor){
            this.autor=autor;
        }
        // llama lo que esta en la variable ISBN
        public void getISBN(int ISBN){
            //escribe lo que esta en la variable ISBN
            Console.WriteLine(this.ISBN);
        }
        // guarda en la variable ISBN
        public void setISBN(int ncode){
            this.ISBN=ncode;
            // llama lo que esta en la variable numerodepaginas
        }public int getnumerodepaginas(){
            // regresa la variable 
            return this.numerodepaginas;
        }
           // guarda lo que esta en la variable numerodepaginas
        public void setnumerdepaginas(int numerodepaginas){
            this.numerodepaginas=numerodepaginas; 
        }
        // escribe el mensaje de la informacion del libro 
         public void tostring (){
         Console.WriteLine("el libro "+this.titulo+" con ISBN "+this.ISBN+"creado por el autor "+this.numerodepaginas+"paginas");
        }
 }




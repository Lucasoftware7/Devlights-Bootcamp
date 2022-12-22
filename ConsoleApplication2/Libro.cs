namespace ConsoleApplication2
{
    public class Libro:Persona
    {
        //Properties 
        private string Author;
        private string Name;
        private int NumberOfPages;
        private bool WasRead;
       
        // Constructor
        public Libro()
        {
  //          Author = author;
    //        Name = name;
      //      NumberOfPages = number_of_pages;
        //    WasRead = was_read;

        }

        //Getters && Setters 
        public string getAuthor()
        {
            return Author;
        }

        public void setAuthor(string paramAuthor)
        {
            Author = paramAuthor;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string paramName)
        {
            Name = paramName;
        }

        public int getNumberOfPages()
        {
            return NumberOfPages;
        }

        public void setNumberOfPages(int paramNumberOfPages)
        {
            NumberOfPages = paramNumberOfPages;
        }

        public bool getWasRead()
        {
            return WasRead;
        }

        public void setWasRead(bool paramWasRead)
        {
            WasRead = paramWasRead;
        }

    }
}
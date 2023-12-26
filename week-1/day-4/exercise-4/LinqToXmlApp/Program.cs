using System.Xml.Linq;

namespace LinqToXmlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assume there is an XML document with the following structure:
            // <Books>
            //     <Book>
            //         <Title>Book Title 1</Title>
            //         <Author>Author 1</Author>
            //         <Genre>Genre 1</Genre>
            //     </Book>
            //     ...
            // </Books>
            // Write above book structure as a c# string
            string xmlString = @"<Books>
                                    <Book>
                                        <Title>Book Title 1</Title>
                                        <Author>Author 1</Author>
                                        <Genre>Genre 1</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 2</Title>
                                        <Author>Author 2</Author>
                                        <Genre>Genre 2</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 3</Title>
                                        <Author>Author 3</Author>
                                        <Genre>Genre 3</Genre>
                                    </Book>
                                </Books>";

            // Create an XDocument object from the XML string\
            XDocument xdoc = XDocument.Parse(xmlString);

            // Write the title of all books to the console
            //Mthod 1:
            var BookTitle1 = from book in xdoc.Descendants("Book")
                         select book.Element("Title").Value; 
            // Method 2:
            var BookTitle2 = xdoc.Descendants("Book").Select(xelelem => xelelem.Element("Title").Value);
            
            foreach (var title in BookTitle1)
            {
                Console.WriteLine(title);
            }
            // Write the title of all books with genre "Genre 1" to the console
            var BookTitleWithGenre1_1 = from book in xdoc.Descendants("Book")
                                      where book.Element("Genre").Value == "Genre 1"
                                      select book.Element("Title").Value;
            var BookTitleWithGenre1_2 = xdoc.Descendants("Book").
                                        Where(book => book.Element("Genre").Value == "Genre 1").
                                        Select(book =>book.Element("Title").Value);
            foreach(var title in BookTitleWithGenre1_2)
            {
                Console.WriteLine(title);
            }


        }
    }
}
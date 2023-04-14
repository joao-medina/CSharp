using ex002PhotoAlbum;
using System;

class Programa
{
    static void Main(string[] args)
    {
        PhotoAlbum myPhotoAlbum = new PhotoAlbum();
        int numberOfPages = myPhotoAlbum.GetNumberOfPages();
        Console.WriteLine("Number of pages: " + numberOfPages);

        Console.WriteLine("Press Enter: ");
        Console.ReadLine();
    }
}
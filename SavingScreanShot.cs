using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
//using System.Windows.Forms;

namespace learnFormEvent
{
    #region Program/Code Documentation 
    /// <summary>
    /// Founed LInk : http://www.c-sharpcorner.com/UploadFile/201fc1/saving-a-screenshot-using-C-Sharp/
    /// Introduction

    //This article explains the entire scenario for creating an image containing a screen content, like windows and other details on the screen. No timer is set in this, each time the application runs it will save the image inside your Documents folder where you can access it.

    //Background

    //Today, I saw the article from a fellow CodeProject user, who tried his best to teach us how to save the screen shot from the screen. But it contained a few bugs and it was not very efficient since a major part of the article was missing and he had not shown the code to the users.

    //Assemblies Required

    //This project, like all others, requires some assemblies. To include them in your project, you make a reference to the namespaces. You can use the Add Reference dialog from the Visual Studio to do so (I am not sure about other IDEs).

    //The required namespaces to be called for this project are as follows:




    //01.using System.Drawing;   
    //02.using System.IO;   
    //03.using System.Windows.Forms;  



    //System.Drawing

    //This namespace is required for graphics, bitmap and so on. Without this, they won't work and you will get an error by the IntelliSense saying this is not found.

    //System.IO

    //This namespace is required to save the (image) file. As the name states, it is a namespace for the Input/output commands. Saving and deleting files inside the file system is done using this!

    //The remaining code is just a simple console application to check for the details on the screen and convert them to the Graphics to be saved in a PNG file.

    //Using the Code

    //The code for the project is as follows:


    //You can see that the code is really very interesting in some places.

    //You create the Graphics from the Image that actually is a Bitmap of 1000x900 size. Once done, you take the pixels from the screen and paste them onto the graphics canvas like:


    //01.// Create graphics from the Image (Bitmap)   
    //02.Graphics memoryGraphics = Graphics.FromImage(memoryImage);   
    //03.   
    //04.// Copy data from screen   
    //05.memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);  


    //Note: s is the Size of the Bitmap itself, see the code.

    //I am using the size of the Bitmap image to create the graphics and then saving the number of content on the Graphics canvas.


    //01.Bitmap memoryImage;   
    //02.memoryImage = new Bitmap(1000, 900);   
    //03.Size s = new Size(memoryImage.Width, memoryImage.Height);  


    //Similarly, the folder and the image name are now dynamic and will always point to your Documents folder, using the special folders on the .NET Framework.


    //01.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Screenshot.png"  



    //..Will give you the folder and the last string is the name of the image. That is "screenshot.png".

    //After all this, you just call the Save method to save the Bitmap.


    //01.memoryImage.Save(str);  



    //To See Result Go to Document

    /// </summary>
    #endregion


    class Program
    {
        // a method to pause the console.   
        // not a part of this project!   
        public static void pause()
        {
            Console.Read();
        }

        static void Main(string[] args)
        {
            // Start the process...   
            Console.WriteLine("Starting the process...");

            Console.WriteLine();
            Bitmap memoryImage;
            memoryImage = new Bitmap(1000, 900);
            Size s = new Size(memoryImage.Width, memoryImage.Height);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);

            //That's it! Save the image in the directory and this will work like charm.   
            string fileName = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                      @"\Screenshot" + "_" +
                      DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png");

            // save it   
            memoryImage.Save(fileName);

            // Write the message,   
            Console.WriteLine("Picture has been saved...");
            // Pause the program to show the message.   
            Program.pause();
        }

    }
}

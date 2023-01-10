using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session4
{
    internal class Button
    {
        //Khai báo event
        public event PrintString Action;

        //Constructor
        public Button(PrintString functionName) //Giong javafx file fxml có <Button onAction = "#functionName">
        {
            Action += functionName;
        }
        
        public void ClickAction()
        {
            Action("Click here");
        }
    }
}

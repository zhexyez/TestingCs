using System;
namespace Test
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        ButtonClicked bc = new ButtonClicked();                                           // 13. Assign a root object to a variable
    //        Reciever_1    rc = new Reciever_1(bc);                                            // 14. Assign a class       to a variable
    //        Reciever_2    rt = new Reciever_2(bc);                                            // 15. <<copy-paste>> of 14.
    //        bc.ThisButtonClicked += rt.Check;                                                 // 16. <<copy-paste>> of 14.
    //        bc.ThisButtonClicked += rc.Check;                                                 // 17. <<copy-paste>> of 14.
    //        bc.OnButtonClicked();                                                             // 18. Call a method, which will raise an event with assigned methods
    //        bc.OnButtonClicked();                                                             // 19. <<copy-paste>> of 18.
    //    }
    //    public class ButtonClicked                                                            // 1.  Create root object, which will do something and contain method to call
    //    {
    //        public delegate void ButtonClickedEventHandler(object sender, string name);       // 2.  Define a  delegate to pick up a methods
    //        public event ButtonClickedEventHandler ThisButtonClicked = null!;                 // 3.  Define an event    to assign methods to ("null!" to let it be defined at first place)
    //        public readonly string name = "button_clicked";                                   // 4.  Just to make it work with current delegate (to match "string name")
    //        public void OnButtonClicked()                                                     // 5.  A method which calls an event
    //        {
    //            if (ThisButtonClicked != null)                                                // 6.  To make sure that event contains assigned methods. Otherwise, it's not so useful
    //                this.ThisButtonClicked(this, this.name);                                  // 7.  Call an event, matching delegate parameters
    //        }
    //    }
    //    public class Reciever_1                                                               // 8.  Create object which will subscribe to an event
    //    {
    //        public Reciever_1(ButtonClicked bc)                                               // 9.  Constructor to add a method to an event (can be just a method, not a constructor)
    //        {
    //            bc.ThisButtonClicked += Check;                                                // 10. Add method to an event
    //        }
    //        public void Check(object _sender, string _name)                                   // 11. Just a method that match a delegate signature
    //        {
    //            Console.WriteLine($"A button {_name} is clicked! 1");                         //
    //        }
    //    }
    //    public class Reciever_2                                                               // 12. << copy-paste>> of a method from above, 8. through 11.
    //    {
    //        public Reciever_2(ButtonClicked bc)                                               //
    //        {
    //            bc.ThisButtonClicked += Check;                                                //
    //        }
    //        public void Check(object _sender, string _name)                                   //
    //        {
    //            Console.WriteLine($"A button {_name} is clicked! 2");                         //
    //        }
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        string str = "wayz";
    //        Console.WriteLine(str);

    //        int[] fromstr = new int[4];
    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            fromstr[i] = Convert.ToInt32(str[i]);
    //        }
    //        for (int i = 0; i < fromstr.Length; i++)
    //        {
    //            if (i == fromstr.Length - 1)
    //            {
    //                Console.WriteLine((char)(fromstr[i - 1] & fromstr[i]));
    //                break;
    //            }
    //            Console.WriteLine((char)(fromstr[i] & fromstr[i]));
    //        }
    //    }
    //}

    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
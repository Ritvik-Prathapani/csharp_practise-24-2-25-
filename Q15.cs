using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    public delegate void ClickHandler();

    // 2️⃣ Define the Button class with an event
    class Button
    {
        public event ClickHandler OnClick; // Declare an event

        // 3️⃣ Method to simulate clicking the button
        public void Click()
        {
            Console.WriteLine("Button Clicked!");
            OnClick?.Invoke();  // Invoke the event if there are subscribers
        }
    }
}

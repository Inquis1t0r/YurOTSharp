using System;
using System.Collections.Generic;
using System.Text;

namespace YurOTSharp
{
    abstract class Account
    {
        UInt32 accnumber;
        int accType;     // ?
        int premDays;    // Premium days

        string name; //accnumber? - Protocol dependent 
        String password;

        List<string> charList;
    }
}

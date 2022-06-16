using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveBibliotek
{

        public class ErrorRespons
        {
            public string ErrorMessege { get; set; }
            public bool Succes { get; set; }
        }

        public class Password
        {
            String inputName;
            String inputPass;
            String controllName;
            String controllPass;
        public void PasswordInput(string name, string pass)
        {
            inputName = name.ToLower();
            inputPass = pass;

        }


        public bool Login()
            {
                bool ok = false;

                if (inputName == controllName && inputPass == controllPass)
                {
                    ok = true;
                }
                return ok;
            }

            public ErrorRespons checkPass(string pass)
            {
                char c;

                bool upper, lower, symbol, space, notName;
                upper = lower = symbol = space = notName = false;

                if (pass.Length < 12)
                {
                    return new ErrorRespons() { ErrorMessege = "Password is to short", Succes = false };
                    //return false; 
                }

                if (char.IsDigit(pass[0]))
                {
                    return new ErrorRespons() { ErrorMessege = "First letter can not be a number", Succes = false };
                    //return false;
                }

                if (char.IsDigit(pass[pass.Length - 1]))
                {
                    return new ErrorRespons() { ErrorMessege = "Last letter can not be a number", Succes = false };
                    //return false;
                }

                for (int i = 0; i < pass.Length; i++)
                {
                    c = pass[i];

                    if (char.IsUpper(c))
                    {
                        upper = true;
                    }
                    if (char.IsLower(c))
                    {
                        lower = true;
                    }
                    if (char.IsSymbol(c))
                    {
                        symbol = true;
                    }
                    if (!char.Equals(c, " "))
                    {
                        space = true;
                    }
                    if (controllName.ToLower() != pass.ToLower())
                    {
                        notName = true;
                    }

                }
                if (upper && lower && symbol && space && notName)
                {
                    return new ErrorRespons() { ErrorMessege = "upper && lower && symbol && space && notName = ok ", Succes = false };
                    //return true;
                }
                return new ErrorRespons() { ErrorMessege = "", Succes = false };
                //return true;
            }

        public object changePass(string pass)
        {
            throw new NotImplementedException();
        }

        public object changeName(string name)
        {
            throw new NotImplementedException();
        }
    }
    }


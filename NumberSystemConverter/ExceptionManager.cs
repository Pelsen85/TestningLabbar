using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemConverter
{
    class ExceptionManager : RomanNumeralConverter
    {
        public class DmInputException : Exception
        {
            public DmInputException() : base()
            {

            }

            public DmInputException(string message) : base(message)
            {

            }

            public override string Message
            {
                get
                {
                    return "Please learn to write Roman correctly! Maybe you meant to write D";
                }
            }
            
            
            }       
        }

    public class LmInputException : Exception
    {
        public LmInputException() : base()
        {

        }

        public LmInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CML?";
            }
        }


    }

    public class ImInputException : Exception
    {
        public ImInputException() : base()
        {

        }

        public ImInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CMXCIX?";
            }
        }


    }

    public class XmInputException : Exception
    {
        public XmInputException() : base()
        {

        }

        public XmInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CMXC?";
            }
        }


    }

    public class VmInputException : Exception
    {
        public VmInputException() : base()
        {

        }

        public VmInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CMXCV?";
            }
        }


    }

    public class LdInputException : Exception
    {
        public LdInputException() : base()
        {

        }

        public LdInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CDL?";
            }
        }


    }

    public class XdInputException : Exception
    {
        public XdInputException() : base()
        {

        }

        public XdInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CDXC?";
            }
        }


    }

    public class VdInputException : Exception
    {
        public VdInputException() : base()
        {

        }

        public VdInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CDXCV?";
            }
        }


    }

    public class IdInputException : Exception
    {
        public IdInputException() : base()
        {

        }

        public IdInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write CDXCIX?";
            }
        }


    }

    public class LcInputException : Exception
    {
        public LcInputException() : base()
        {

        }

        public LcInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write L?";
            }
        }


    }

    public class VcInputException : Exception
    {
        public VcInputException() : base()
        {

        }

        public VcInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write XCV?";
            }
        }


    }

    public class IcInputException : Exception
    {
        public IcInputException() : base()
        {

        }

        public IcInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write XCIX?";
            }
        }


    }

    public class VlInputException : Exception
    {
        public VlInputException() : base()
        {

        }

        public VlInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write XLV?";
            }
        }


    }

    public class IlInputException : Exception
    {
        public IlInputException() : base()
        {

        }

        public IlInputException(string message) : base(message)
        {

        }

        public override string Message
        {
            get
            {
                return "Please learn to write Roman correctly! Maybe you meant to write XLIX?";
            }
        }


    }

    public class IiiiInputException : Exception
    { 
    public IiiiInputException() : base()
    {

    }

    public IiiiInputException(string message) : base(message)
        {

    }

    public override string Message
    {
        get
        {
            return "Please learn to write Roman correctly! Maybe you meant to write IV?";
        }
    }


}
}

    


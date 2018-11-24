using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    class Invalid_Value: Exception
    {
        public string message;
	
	    public Invalid_Value() 
	    {
		    this.message = "Valeur non autorisee";
	    }

	    public Invalid_Value(string t_message)
	    {
		    this.message = t_message;
	    }
    }
}

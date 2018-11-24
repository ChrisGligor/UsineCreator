using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    class MEsGaz: Mtherm
    {
        private bool gaz;
        
        public MEsGaz()
        {

        }

        public MEsGaz(int t_Puis, int t_Vrot): base(t_Puis, t_Vrot)
        {

        }

        public MEsGaz(MEsGaz r_MEsGaz) : base(r_MEsGaz)
        {
            this.gaz = r_MEsGaz.gaz;
        }

        ~MEsGaz() 
        {

        }

        public void set_gaz(bool t_gaz)
        {
	        this.gaz = t_gaz;
        }

        public bool get_gaz()
        {
	        return this.gaz;
        }

        public override void intro(int t_nbCyl, int t_Cyl, bool t_gaz)
        {
            base.intro(t_nbCyl, t_Cyl);
            this.set_gaz(t_gaz);
        }

        public override bool recup()
        {
            return this.get_gaz();
        }

        public override int recup(bool t_recup)
        {
           return base.recup(t_recup);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    class Mdies : Mtherm
    {
        private bool ID;

        public Mdies()
        {

        }

        public Mdies(int t_Puis, int t_Vrot): base(t_Puis, t_Vrot)
        {

        }

        public Mdies(Mdies r_Mdies) : base(r_Mdies)
        {
            this.ID = r_Mdies.ID;
        }

        ~Mdies() 
        {

        }

        public void set_ID(bool t_ID)
        {
	        this.ID = t_ID;
        }

        public bool get_ID()
        {
	        return this.ID;
        }

        public override void intro(int t_nbCyl, int t_Cyl, bool t_ID)
        {
            base.intro(t_nbCyl, t_Cyl);
            this.set_ID(t_ID);
        }

        public override bool recup()
        {
            return this.get_ID();
        }

        public override int recup(bool t_recup)
        {
            return base.recup(t_recup);
        }
    }
}
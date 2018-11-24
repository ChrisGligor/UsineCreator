using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    class Mtherm : Mot
    {
	    protected int Cyl;
	    protected int nbCyl;

        public Mtherm()
        {

        }

        public Mtherm(int t_Puis, int t_Vrot): base(t_Puis, t_Vrot)
        {

        }

        public Mtherm(Mtherm r_Mtherm) : base(r_Mtherm)
        {
        	this.Cyl = r_Mtherm.Cyl;
        	this.nbCyl = r_Mtherm.nbCyl;
        }

        ~Mtherm() 
        {

        }

        public int get_Cyl()
        {
	        return this.Cyl;
        }

        public int get_nbCyl()
        {
	        return this.nbCyl;
        }

        public void set_Cyl(int t_Cyl)
        {
	        if(t_Cyl > 0) this.Cyl = t_Cyl;
            else throw new Invalid_Value("Cylindree > 0");
        }

        public void set_nbCyl(int t_nbCyl)
        {
	        if(t_nbCyl > 0)this.nbCyl = t_nbCyl;
            else throw new Invalid_Value("Nb Cylindres > 0");
        }

        public override void intro(int t_nbCyl, int t_Cyl, bool NU = false) 
        {
            this.set_nbCyl(t_nbCyl);
            this.set_Cyl(t_Cyl);
        }

        public override int recup(bool t_recup) 
        {
            if (t_recup) return this.get_nbCyl();
            else return this.get_Cyl();
        }
    }
}
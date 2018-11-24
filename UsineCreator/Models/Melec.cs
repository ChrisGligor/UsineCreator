using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    class Melec : Mot
    {
        protected bool Conti;
	    protected int nbob;
        
        public Melec()
        {

        }

        public Melec(int t_Puis, int t_Vrot): base(t_Puis, t_Vrot)
        {
	
        }

        public Melec(Melec r_Melec) : base(r_Melec)
        {
        	this.Conti = r_Melec.Conti;
        	this.nbob = r_Melec.nbob;
        }

        ~Melec() 
        {

        }

        public bool get_Conti()
        {
	        return this.Conti;
        }

        public int get_nbob()
        {
	        return this.nbob;
        }

        public void set_Conti(bool t_Conti)
        {
	        this.Conti = t_Conti;
        }

        public void set_nbob(int t_nbob)
        {
            if (t_nbob > 0) this.nbob = t_nbob;
            else throw new Invalid_Value("Nbob > 0");
        }

        public override void intro(int t_nbob, int NU, bool t_Conti)
        {
            this.set_nbob(t_nbob);
            this.set_Conti(t_Conti);
        }

        public override bool recup()
        {
            return this.get_Conti();
        }

        public override int recup(bool t_recup)
        {
            return this.get_nbob();
        }
    }
}
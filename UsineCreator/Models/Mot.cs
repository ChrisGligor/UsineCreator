using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    public abstract class Mot
    {
        private int Puis;
        private int Vrot;
        private string NoS;

        public Mot()
        {

        }

        ~Mot() 
        {

        }

        public Mot(int t_Puis, int t_Vrot)
        {
            this.Puis = t_Puis;
            this.Vrot = t_Vrot;
        }


        public Mot(Mot r_mot)
        {
            this.Puis = r_mot.Puis;
            this.Vrot = r_mot.Vrot;
            this.NoS = r_mot.NoS;
        }


        public int get_Puis()
        {
            return this.Puis;
        }

        public int get_Vrot()
        {
            return this.Vrot;
        }

        public string get_NoS()
        {
            return this.NoS;
        }

        public void set_Puis(int t_Puis)
        {
            if (t_Puis > 0) this.Puis = t_Puis;
            else throw new Invalid_Value("Pmot > 0");
        }

        public void set_Vrot(int t_Vrot)
        {
            if(t_Vrot > 0) this.Vrot = t_Vrot;
            else throw new Invalid_Value("Vrot > 0");
        }

        public void set_NoS(string t_NoS)
        {
            this.NoS = t_NoS;
        }

        public virtual void intro(int a, int b, bool c) { }
        public virtual bool recup() { return false; }
        public virtual int recup(bool c) { return 0; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usine
{
    public class Usine
    {
        private int id;
        private string Loc;
        private Mot[] TabMot;

        public Usine() 
        {
            Array.Resize(ref TabMot, 0);
        }

        public Usine(int t_id, string t_Loc) 
        {
            this.set_id(t_id);
            this.set_Loc(t_Loc);
            Array.Resize(ref TabMot, 0);
        }

        public Usine(Usine r_Usine) 
        {            
            this.id = r_Usine.id;
            this.Loc = r_Usine.Loc;
            Array.Resize(ref TabMot, r_Usine.TabMot.Length);

            string typMot = "";
            for (uint x = 0; x < TabMot.Length; x++)
            {
                typMot = r_Usine.TabMot[x].GetType().ToString();
                switch (typMot)
                {
                    case "Usine.Mtherm":
                        TabMot[x] = new Mtherm((Mtherm) r_Usine.TabMot[x]);
                        break;
                    case "Usine.Mdies":
                        TabMot[x] = new Mdies((Mdies)r_Usine.TabMot[x]);
                        break;
                    case "Usine.MEsGaz":
                        TabMot[x] = new MEsGaz((MEsGaz)r_Usine.TabMot[x]);
                        break;
                    case "Usine.Melec":
                        TabMot[x] = new Melec((Melec)r_Usine.TabMot[x]);
                        break;
                    default:
                        break;
                }
            }
        }

        ~Usine() 
        {
            Array.Clear(TabMot, 0, TabMot.Length);
        }

        public void set_id(int t_id)
        {
            if (t_id > 0) this.id = t_id;
            else throw new Invalid_Value("Id > 0");
        }

        public void set_Loc(string t_Loc)
        {
            this.Loc = t_Loc;
        }

        public int get_id()
        {
            return this.id;
        }

        public string get_Loc() 
        {
            return this.Loc;
        }

        public Mot[] get_TabMot()
        {
            return this.TabMot;
        }

        public void resize_bigger_TabMot()
        {
            Array.Resize(ref TabMot, TabMot.Length + 1);
        }

        public void resize_smaller_TabMot()
        {
            Array.Resize(ref TabMot, TabMot.Length - 1);
        }

        public void remove_Mot(int t_index) 
        {
            var List = new List<Mot>(TabMot);
            List.RemoveAt(t_index);
            TabMot = List.ToArray();
            System.GC.Collect();
        }
    }
}

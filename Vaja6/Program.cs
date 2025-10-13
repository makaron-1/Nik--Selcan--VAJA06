using System.IO;

namespace vaja6 {

    public enum Razred { Bojevnik, Carovnik, Menih, Tat };

    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id {
            get
            {
                return id;
            }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
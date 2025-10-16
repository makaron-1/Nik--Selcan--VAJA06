using System.IO;

namespace vaja6 {

    private enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

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
            }//vrne id igralca
        }

        public string U_ime {
            get
            {
                return u_ime;
            }//vrne ime igralca
            set
            {
                u_ime = value.Trim();
            }//vrne skrajsano ime
        }

        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }//vrne geslo in ga skrajsa

        public static int StIg
        {
            get { return stIg; }
        }//vrne stevilo igralca
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}

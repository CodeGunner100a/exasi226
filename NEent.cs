
        
        //clase nent
        private int n;


        public NEnt()
        {
            n = 0;
        }


        public void Cargar(int dato)
        {
            n = dato;
        }

        public int Descargar()
        {
            return n;
        }

        public bool VerifPrimo()
        {
            int c = 0;
            bool ban = true;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c = c + 1;
                }
            }

            if (c == 2)
            {
                ban = true;
            }
            else
            {
                ban = false;
            }

            return ban;
        }

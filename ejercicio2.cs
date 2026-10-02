
//ejercicio 2

   public void ejercicio2(int a, int b)
        {
            int p = a;

            for (int i = a; i <= b; i++)
            {
                NEnt num = new NEnt();
                num.Cargar(v[i]);

                if (num.VerifPrimo())
                {
                    intercambiar(i, p);
                    p++;
                }
            }

            Ordenar_Asc_Rango(a, p - 1);
            Ordenar_Asc_Rango(p, b);
        }

        public void intercambiar(int pos1, int pos2)
        {
            int aux;

            aux = v[pos1];
            v[pos1] = v[pos2];
            v[pos2] = aux;
        }

        public void Ordenar_Asc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] < v[i])
                    {
                        intercambiar(i, j);
                    }
                }
            }
        }


//llamada
     v1.ejercicio2(int.Parse(textBox2.Text), int.Parse(textBox3.Text));      


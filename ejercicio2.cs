
//ejercicio 2

  public void ejercicio2(int a, int b, ref Vector e, ref Vector f)
        {
            e.n = 0;
            f.n = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] % 2 != 0) // impar
                {
                    if (!e.Existe_ele(v[i])) // no repetir
                    {
                        e.insertar(v[i]);

                        int frec = frecuencia_rango(v[i], a, b);
                        f.insertar(frec);
                    }
                }
            }

            ordenarParaleloAsc(ref e, ref f);
        }

        public int frecuencia_rango(int ele, int a, int b)
        {
            int cont = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                {
                    cont++;
                }
            }

            return cont;
        }

        //Método para ordenar paralelo asc
        public void ordenarParaleloAsc(ref Vector e, ref Vector f)
        {
            for (int i = 1; i < e.n; i++)
            {
                for (int j = i + 1; j <= e.n; j++)
                {
                    if (e.v[i] > e.v[j])
                    {
                        intercambiar(ref e, ref f, i, j);
                    }
                }
            }
        }

        public void intercambiar(ref Vector e, ref Vector f, int i, int j)
        {
            int aux = e.v[i];
            e.v[i] = e.v[j];
            e.v[j] = aux;

            int aux2 = f.v[i];
            f.v[i] = f.v[j];
            f.v[j] = aux2;
        }



//llamada
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);

            v1.ejercicio2(a, b, ref v2, ref v3);



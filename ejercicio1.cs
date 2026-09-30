// ejercicio 1

  public void Ejercicio1(ref Vector R)
        {
            R.n = 0;

            for (int i = 1; i <= n; i++)
            {
                int cont = 0;


                for (int j = 1; j <= n; j++)
                {
                    if (v[i] == v[j])
                    {
                        cont++;
                    }
                }


                if (cont > 1)
                {

                    if (R.Existe_ele(v[i]) == false)
                    {
                        R.insertar(v[i]);
                    }
                }
            }
        }

        public bool Existe_ele(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                {
                    ban = true;
                }
                else
                {
                    i = i + 1;
                }

            }

            return ban;
        }

        public void insertar(int elemento)
        {
            n = n + 1; v[n] = elemento;

        }

//llamada

 v1.Ejercicio1(ref v2);




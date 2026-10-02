// ejercicio 1

  public void ejercicio1(Vector v2, ref Vector vr)
        {
            vr.n = 0;

         
            for (int i = 1; i <= n; i++)
            {
                if (v2.Buscar_ele(v[i]) == false)
                {
                    if (vr.Buscar_ele(v[i]) == false)
                    {
                        vr.insertar(v[i]);
                    }
                }
            }

           
            for (int i = 1; i <= v2.n; i++)
            {
                if (Buscar_ele(v2.v[i]) == false)
                {
                    if (vr.Buscar_ele(v2.v[i]) == false)
                    {
                        vr.insertar(v2.v[i]);
                    }
                }
            }
        }

        public bool Buscar_ele(int ele)
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
                    i++;
                }
            }

            return ban;
        }

        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;
        }

//llamada

            v1.ejercicio1(v2, ref v3);
          




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class PhanSo
    {
        private int tuso;
        private int mauso;

        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void toiGian(PhanSo a)
        {
            int ucln =timucln(a);
            tuso = tuso / ucln;
            mauso = mauso / ucln;
        }
        public int timucln(PhanSo a)
        {
            int ucln=0;
            int x = Math.Abs(a.tuso);
            int y = Math.Abs(a.mauso);
            if (x > y)
            {
                for (int i = 1; i <=y; i++)
                {
                    if (x % i == 0 && y % i == 0)
                    {
                        ucln = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <=x; i++)
                {
                    if (x % i == 0 && y % i == 0)
                    {
                        ucln = i;
                    }
                }
            }
            return ucln;

        }
        public PhanSo cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }
    }
}

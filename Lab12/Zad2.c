#include <stdio.h>

struct QQ {
    int a;
    double b;
};

int main()
{
  struct QQ q;
  printf("Size QQ = %d \n", sizeof(q));
  struct QQ tab[20][30];
  printf("Size tab = %d \n", sizeof(tab));
  /* -- Notatki
   1000+(2*20+1)*4 powinno 1164
   1000+(41*4)
   1000 + 164 = 1164
  --
  tab[0][0] : 5000 - 5015
  tab[0][0].a : 5000 - 5007
  tab[5][10] = 5000 + (5*30 + 10)*16 = 7560 - 7575
  */
  return(0);
}

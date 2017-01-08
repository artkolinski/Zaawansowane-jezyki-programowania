#include <stdio.h>
#pragma pack(push)
#pragma pack(1)
struct QQ {
    int a;
    double b;
};
#pragma pack(pop)
int adrStart(int wartoscStart,int calkIloscKolumn, int kolumna, int wiersz, int rozmiarStruktury){
int obl = wartoscStart + (kolumna*calkIloscKolumn + wiersz)*rozmiarStruktury;
return (obl);
};

int main()
{
  struct QQ q;
  printf("Size QQ = %d \n", sizeof(q));
  struct QQ tab[15][10];
  printf("Size tab = %d \n", sizeof(tab));
  int obl = 2000 + (5*15+10)*12;
  printf("adr startowy tab[5][10] = %d \n", obl);
  int obl2 = adrStart(2000,15,5,10,12);
  printf("Funkcja adr startowy tab[5][10] = %d \n", obl2);
  int obl4 = adrStart(846320,10,2,3,152);
  printf("Funkcja adr startowy tab[2][3] = %d \n", obl4);
  return(0);
}

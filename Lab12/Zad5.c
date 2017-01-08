#include <stdio.h>

int adrStart2(int wartoscStart,int n, int m, int p, int i, int j, int k, int rozmiarStruktury){
int obl = wartoscStart + ((i*m+j)*p+k)*rozmiarStruktury;
return (obl);
};

int adrStartComplex(int wartoscStart, int i, int j, int k, int rozmiarStruktury,int c, int kk){
// tab[n][m][p]
int n=10, m=100, p=20;
int obl = wartoscStart + ((i*m+j)*p+k)*rozmiarStruktury;
// .zmienna[c][kk]
char b[10][15];
int obl2 =  adrStart2dimm(obl,10,c,kk,sizeof(b));
return (obl2);
};

int adrStart2dimm(int wartoscStart,int calkIloscKolumn, int kolumna, int wiersz, int rozmiarStruktury){
int obl = wartoscStart + (kolumna*calkIloscKolumn + wiersz)*rozmiarStruktury;
return (obl);
};

int main()
{
  // tab[n][m][p]
  // tab[i][j][k]
  printf("\n\n - Funkcja adr startowy tab[2][3][4] = %d \n", adrStart2(1000,10,100,20,2,3,4,208));
  int adrStart = adrStartComplex(1000,2,3,4,208,2,3);
  printf("b) 846353");
  printf("\n - adresowanie tab[2][3][4].b[2][3] : %d - %d \n", adrStart, adrStart+208);
  /* -- Notatki
   846312 - 846319
   846320 - 846472 (152)
   tab[2][3][4].b[2][3] - 846353
   b[2][3] 846519
   poprawna odp. b) 846353
  */
  return(0);
}

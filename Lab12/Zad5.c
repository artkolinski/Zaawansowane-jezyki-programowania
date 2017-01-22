#include <stdio.h>

int adrStart2(int wartoscStart,int n, int m, int p, int i, int j, int k, int rozmiarStruktury){
// tab[n][m][p]  <- zadeklarowana tablica
// tab[10][100][20]
// -----------------
// tab[i][j][k]  <- tablica ktora liczymy
// tab[2][3][4]
int obl = wartoscStart + ((i*m+j)*p+k)*rozmiarStruktury;
return (obl);
};

struct ABC {
    double a;
    char b[10][15];
    int c[12];
};

int main()
{
  struct ABC abc;
  printf("Size ABC = %d", sizeof(abc));
  printf("\n\n - Funkcja adr startowy tab[2][3][4] = %d \n", adrStart2(1000,10,100,20,2,3,4,208));
  return(0);
}

#include <stdio.h>

int main()
{
  int  n, c, d, swap;
  printf("Podaj ilosc elementow : ");
  scanf("%d", &n);
  int array[n];
  printf("---------------");
  for (c = 0; c < n; c++)
    scanf("%d", &(*(array+c)));

  for (c = 0 ; c < ( n - 1 ); c++)
  {
    for (d = 0 ; d < n - c - 1; d++)
    {
      if (*(array+d) > *(array+d+1))
      {
        swap       = *(array+d);
        *(array+d)   = *(array+d+1);
        *(array+d+1) = swap;
      }
    }
  }
  printf("Posortowane :\n");
  for ( c = 0 ; c < n ; c++ )
     printf("%d\n", *(array+c));
  return 0;
}

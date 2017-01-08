#include <stdio.h>

struct QQ4 {
    int a;
    char b;
    char c;
};

struct QQ5 {
    char a;
    int b;
    char c;
};

int main()
{
  struct QQ5 q5;
  struct QQ4 q4;
  printf("Size QQ4 = %d, QQ5 = %d", sizeof(q4), sizeof(q5));
  return(0);
}

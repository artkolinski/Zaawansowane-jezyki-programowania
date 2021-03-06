#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define max_sons 4
#define max_width_print 100
#define max_height_print 40

typedef enum {FALSE, TRUE} Bool;
typedef enum {
  A,
  B,
  S
} NotTerminal;

typedef struct tr{
  Bool term;
  char lk;
  NotTerminal ntm;
  int sizeSons;
  struct tr* sons[max_sons];
} tree;

char nextChar;
Bool stateS = TRUE;

Bool NewLeks(char c){
  if (nextChar == c){
    do {
      nextChar = getchar();
    } while((nextChar < '!' || nextChar > '~') && nextChar != '\n');
    return TRUE;
  }
  else
    return FALSE;
}

Bool Error(char s[]){
  printf("\n ERROR: %s\n\n", s);
  return FALSE;
}
Bool SS(tree *drz);
Bool AA(tree *drz);
Bool BB(tree *drz);
Bool SS(tree *drz){
    if(AA(&drz) & BB(&drz))
        return TRUE;
    else
        return FALSE;
}

Bool BB(tree *drz){
  tree temp1;
  if(NewLeks('b'))
  {
      if(BB(&temp1)){
          drz->term = FALSE;
          drz->ntm = B;
          drz->sizeSons = 2;

          drz->sons[0] = (tree*)malloc(sizeof(tree));
          drz->sons[0]->term = TRUE;
          drz->sons[0]->lk = 'b';

          drz->sons[1] = (tree*)malloc(sizeof(tree));
          *(drz->sons[1]) = temp1;

          return TRUE;
        }
      else return Error("b ??? --- <B>");
  }
  else
    if(NewLeks('x')){
      drz->term = FALSE;
      drz->ntm = B;
      drz->sizeSons = 1;

      drz->sons[0] = (tree*)malloc(sizeof(tree));
      drz->sons[0]->term = TRUE;
      drz->sons[0]->lk = 'x';
      return TRUE;
    }
    else
      return FALSE;

}
Bool AA(tree *drz){
  tree temp1;
  if(NewLeks('a'))
  {
      if(AA(&temp1)){
          drz->term = FALSE;
          drz->ntm = A;
          drz->sizeSons = 2;

          drz->sons[0] = (tree*)malloc(sizeof(tree));
          drz->sons[0]->term = TRUE;
          drz->sons[0]->lk = 'a';

          drz->sons[1] = (tree*)malloc(sizeof(tree));
          *(drz->sons[1]) = temp1;

          return TRUE;
        }
      else return Error("a ??? --- <A>");
  }
  else
    if(NewLeks('x')){
      drz->term = FALSE;
      drz->ntm = B;
      drz->sizeSons = 1;

      drz->sons[0] = (tree*)malloc(sizeof(tree));
      drz->sons[0]->term = TRUE;
      drz->sons[0]->lk = 'x';
      return TRUE;
    }
    else
      return FALSE;
}

/* Print tree */
char printTab[max_width_print][max_height_print];

void TreeDr(tree drz, int *width, int *height){
  int widthSons[max_sons], heightSons[max_sons],i,j;
  if(drz.term){
    *width =  *width+3;
    *height=1;
    printTab[*width-1][*height-1] = drz.lk;
  }
  else{
    *height = 0;
    for(i=0; i<drz.sizeSons; i++){
      TreeDr(*drz.sons[i], width, &heightSons[i]);
      widthSons[i] = *width;
      if(*height < heightSons[i]){
        *height = heightSons[i];
      }
    }
      switch (drz.ntm) {
        case A:
          printTab[*width-1][*height+1] = 'A';
          break;
        case B:
          printTab[*width-1][*height+1] = 'B';
          break;
        case S:
          printTab[*width-1][*height+1] = 'S';
          break;
      }
      if (drz.sizeSons > 0) {
      for (i=0; i<drz.sizeSons; i++){
        for (j=heightSons[i]; j<*height+1; j++)
          printTab[widthSons[i]-1][j] = '|';
      }
      for (i=widthSons[0]; i<*width-1; i++){
        printTab[i][*height+1] = '-';
      }
      for (i=0; i<drz.sizeSons-1; i++){
        printTab[widthSons[i]-1][*height+1] = ',';
      }
    }
      *height = *height + 2;
  }
}

void PrintTree(tree drz){
  int width, height,i,j;
  for(i=0; i<max_width_print; i++){
    for(j=0; j<max_height_print; j++){
      printTab[i][j] = ' ';
    }
  }
  width = 0;
  TreeDr(drz, &width, &height);
  for(j=height-1; j>=0; j--){
    for(i=0; i<width; i++){
      putchar(printTab[i][j]);
    }
    putchar('\n');
  }
  putchar('\n');
}

void FreeTree(tree *drz){
  int i;
  for(i=0; i<drz->sizeSons; i++){
    FreeTree(drz->sons[i]);
    free(drz->sons[i]);
  }
}

int main(void){

  tree drz;
  Bool ok;
  while(TRUE){
  do {
    nextChar = getchar();
  } while((nextChar < '!' || nextChar > '~') && nextChar != '\n');
  ok = SS(&drz);
  putchar('\n');

  if(ok && nextChar == '\n'){
    //PrintTree(drz);
    printf("Jest OK :)\n");
  }
  else{
    if(ok && nextChar != '\n'){
      //PrintTree(drz);
      printf("TRASH: %c\n\n",nextChar);
    }
    else{
      printf("INPUT ERROR\n");
    }
  }

}
FreeTree(&drz);
  return EXIT_SUCCESS;
}

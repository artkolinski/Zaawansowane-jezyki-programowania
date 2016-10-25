/* Prosty Jezyk dla Obliczen -- interpreter
 * Kolejnosc przetwarzania:
 *  (1) bison 3-pjo.y
 *  (2) gcc -o 3-pjo 3-pjo.tab.c
 * Wywolanie:
 *      ./3-pjo
 */

%{
 #include <stdio.h>
 #include <stdlib.h>
 #define YYERROR_VERBOSE 1
 #define YYSTYPE int
 #define L_ZMIENNYCH 26

 void  yyerror (const char s[]) {
   // wywolywane przez  yyparse  w razie bledu
   printf ("!!! %s\n", s);
 }

 YYSTYPE  yylex (void) {  // puste
   int c;
   do  { c = getchar (); }
   while (c == ' ' || c == '\t' || c == '\n');
   if (c == EOF)  return 0;
   else  return c;
 }

%}

 %token NUM

%%
    /* Gramatyka: */
program: komendy ';' {exit(0);printf("poprawne AnBn\n");}
komendy:  | komendy wyrazenie
wyrazenie:   litery '.' { printf("poprawne AnBn\n");}
 ;

litery:     'a' litery 'b'
            | 'a' 'b'
;
/****************************************************/
%%

int main (void) {
 printf("UZYTKOWNIK> ");
 return yyparse ();
}

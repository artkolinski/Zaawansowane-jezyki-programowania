%{
  #include <stdio.h>
  #include <math.h>
  #define YYSTYPE double
  int yylex(void);
  void yyerror(char const *s);
%}

%token NUM
%left '-' '+'
%left '*' '/'
%left '!'
%left '&'
%left 'o'
%left 'i'
%left '#'
%left NEG
%right '^'

%%
input: /* empty */ | input line;
line: '\n' | exp '\n' {printf("\t%.10g\n", $1);} | error '\n' {yyerrok;};
exp: NUM |
  exp '+' exp {$$ = $1 + $3;} |
  exp '-' exp {$$ = $1 - $3;} |
  exp '*' exp {$$ = $1 * $3;} |
  exp '/' exp {$$ = $1 / $3;} |
  '-' exp  %prec NEG { $$ = -$2;        }|
  '!' exp {$$=!($2);}|
  exp '&' exp {$$=(int) $1 & (int) $3;}|
  exp 'o' exp {$$=(int) $1 | (int) $3;}|
  exp 'i' exp {if((int)$1 == 1 & (int) $3 == 0) $$=0; else $$=1;}|
  /*exp '#' exp {if(((int)$1 == 1 & (int) $3 == 1) | ((int)$1 == 0 & (int) $3 == 0)) $$=1; else $$=0;}|*/
  exp '#' exp {if((int)$1 == (int)$3) $$=1; else $$=0;}|
  exp '^' exp {$$ = pow($1, $3);} |
  '('exp')' {$$ = $2;};
%%

#include <ctype.h>
int yylex(void) {
  int c;
  while((c = getchar()) == ' ' || c == '\t') {
    continue;
  }
  if (c == '.' || isdigit(c)) {
    ungetc(c, stdin);
    scanf("%lf", &yylval);
    return NUM;
  }
  if (c == EOF) {
    return 0;
  }
  return c;
}
#include <stdio.h>
void yyerror(char const *s) {
  fprintf(stderr, "%s\n", s);
}

int main()
{
  return yyparse();
}

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
%left 'and'
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
  exp 'and' exp {$$=((int)$1)&((int)$3);}|
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

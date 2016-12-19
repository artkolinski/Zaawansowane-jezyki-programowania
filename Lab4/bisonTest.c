%{
  #include <stdio.h>
  #include <math.h>
  int yylex(void);
  void yyerror(char const *s);
%}

%define api.value.type {double}
%token NUM
%left '-' '+'
%right '*' '/'
%precedence NEG
%right '^'

%% /*gramatyka */
input: %empty | input line;
line: '\n' | exp '\n' {printf("\t%.10g\n", $1);} | error '\n' {yyerrok;};
exp: NUM |
  exp '+' exp {$$ = $1 + $3;} |
  exp '-' exp {$$ = $1 - $3;} |
  exp '*' exp {$$ = $1 * $3;} |
  exp '/' exp {$$ = $1 / $3;} |
  '-' exp %prec NEG {$$ = -$2;} |
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

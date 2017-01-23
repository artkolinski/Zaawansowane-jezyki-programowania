#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <ctype.h>
#include <sys/types.h>

int main() {
	char ch;
	FILE *fp;
	printf("Proces rodzicielski %d\n",getpid());
	fp = fopen("ala.txt", "r");
	while( ( ch = fgetc(fp) ) != EOF )
      printf("%c",ch);
    fclose(fp);
	if(fork()==0){
		printf("\nProces potomny %d\n",getpid());
		fp = fopen("ala.txt", "r");
		while( ( ch = fgetc(fp) ) != EOF )
            printf("%c",tolower(ch));
		fclose(fp);
		_exit(0);
	}else{
        wait();
	}
	printf("\nProces rodzicielski %d\n",getpid());
return 0;
}

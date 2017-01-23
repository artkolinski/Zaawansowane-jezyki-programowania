#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>

int f(int a){
	
	return a*a;
}

int main() {
	int a,b;
	printf("Proces rodzicielski %d\n",getpid());	
	scanf("%i",&a);
	if(fork()==0){
		printf("Proces potomny %d\n",getpid());
		b = f(a);
		printf("f(%d)=%d\n",a,b);
		_exit(0);
	}	
	wait();
	printf("Proces rodzicielski %d\n",getpid());	
return 0;
}

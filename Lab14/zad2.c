#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>

void f(int a){
	for(int i= 0; i<a; i++){
		if(fork()==0){
			printf("Proces potomny %d %d\n",getpid(),getppid());
			_exit(0);
		}else{
		wait();
		}
	}
}

int main() {
	int a;
	printf("Proces rodzicielski %d\n",getpid());
	if(fork()==0){
		printf("Proces potomny %d\n",getpid());
		scanf("%i",&a);
		f(a);
		_exit(0);
	}else{
	wait();
	}
	printf("Proces rodzicielski %d\n",getpid());
return 0;
}

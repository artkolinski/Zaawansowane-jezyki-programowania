#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <sys/time.h>
#include <time.h>

static struct timeval tm1;
//clock_t begin;

static inline void start()
{
    clock_t begin = clock();
    //gettimeofday(&tm1, NULL);
}

static inline void stop()
{
    //struct timeval tm2;
    //gettimeofday(&tm2, NULL);
    //unsigned long long t = 1000 * (tm2.tv_sec - tm1.tv_sec) + (tm2.tv_usec - tm1.tv_usec) / 1000;
    clock_t end = clock();
//    double time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
   // printf("%llu ms\n", time_spent);
}

void waitFor (unsigned int secs) {
    unsigned int retTime = time(0) + secs;
    while (time(0) < retTime);
}

void MallocTest(){
                    printf("Malloc 10k\n");
                    clock_t begin = clock();
                    int i;
                    for(i=0; i<10000;i++){
                        double *tabA = malloc (sizeof(double)*10000);
                    }

                    clock_t end = clock();
                    double time_spent = (double)(end - begin)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent);

                    printf("Malloc 100k\n");
                    clock_t begin2 = clock();
                    for(i=0; i<10000;i++){
                        double *tabB = malloc (sizeof(double)*100000);
                    }

                    clock_t end2 = clock();
                    double time_spent2 = (double)(end2 - begin2)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent);

                    printf("Malloc 1mln\n");
                    clock_t begin3 = clock();
                    for(i=0; i<10000;i++){
                        double *tabB = malloc (sizeof(double)*1000000);
                    }
                    clock_t end3 = clock();
                    double time_spent3 = (double)(end3 - begin3)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent3);
}

void CallocTest(){
                    printf("calloc 10k\n");
                    clock_t begin4 = clock();
                    int i;
                    for(i=0; i<10000;i++){
                        double *tabA = calloc (10000,sizeof(double)*10000);
                    }

                    clock_t end4 = clock();
                    double time_spent4 = (double)(end4 - begin4)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent4);

                    printf("calloc 100k\n");
                    clock_t begin5 = clock();
                    for(i=0; i<10000;i++){
                        double *tabB = calloc (100000,sizeof(double)*100000);
                    }

                    clock_t end5 = clock();
                    double time_spent5 = (double)(end5 - begin5)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent5);

                    printf("calloc 1mln\n");
                    clock_t begin6 = clock();
                    for(i=0; i<10000;i++){
                        double *tabB = calloc (1000000,sizeof(double)*1000000);
                    }
                    clock_t end6 = clock();
                    double time_spent6 = (double)(end6 - begin6)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent6);
}
void NewTest(){
                    printf("new 10k\n");
                    clock_t begin14 = clock();
                    int i;
                    for(i=0; i<10000;i++){
                        double tab11[10000];
                    }

                    clock_t end14 = clock();
                    double time_spent14 = (double)(end14 - begin14)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent14);

                    printf("new 100k\n");
                    clock_t begin5 = clock();
                    for(i=0; i<10000;i++){
                        double tab22[100000];
                    }

                    clock_t end5 = clock();
                    double time_spent5 = (double)(end5 - begin5)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent5);

                    printf("new 1mln\n");
                    clock_t begin6 = clock();
                    for(i=0; i<100000;i++){
                        double tab33[100000];
                    }
                    clock_t end6 = clock();
                    double time_spent6 = (double)(end6 - begin6)*1000 / CLOCKS_PER_SEC;
                    printf("%lf ms\n", time_spent6);
}

int main()
{
srand ( time(NULL) );
MallocTest();
CallocTest();
NewTest();
return 0;
}

#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <sys/time.h>

static struct timeval tm1;
int RandomInt(){
   return rand() % 1001;
}

double RandomDouble(){
    return (double)rand()/RAND_MAX*2.0-1.0;
}

static inline void start()
{
    gettimeofday(&tm1, NULL);
}

static inline void stop()
{
    struct timeval tm2;
    gettimeofday(&tm2, NULL);
    unsigned long long t = 1000 * (tm2.tv_sec - tm1.tv_sec) + (tm2.tv_usec - tm1.tv_usec) / 1000;
    printf("%llu ms\n", t);
}

void waitFor (unsigned int secs) {
    unsigned int retTime = time(0) + secs;
    while (time(0) < retTime);
}

void ScalarProduct(){
int testCount;
long int tableLength, a, i;
for (testCount = 0; testCount < 1; testCount++)
            {
                for (i = 100000; i < 1000000000; i *= 10)
                {
                    // Generate tables
                    double *tabA = malloc (sizeof(double)*i);
                    double *tabB = malloc (sizeof(double)*i);
                    for (tableLength = 0; tableLength < i; tableLength++ )
                        {
                            tabA[tableLength] = RandomDouble();
                            tabB[tableLength] = RandomDouble();
                            //printf("%d, %d, ",tabA[tableLength],tabB[tableLength]);
                        }
                    // Scalar Product
                    double t_begin, t_end;
                    start();
                    double scalarProduct = 0;
                    for (a = 0; a < i; a++ )
                        {
                            scalarProduct = scalarProduct + (tabA[a] * tabB[a]);
                            //printf("%d * %d, ",tabA[a],tabB[a]);
                        }
                    printf("scalarProduct = %lld \n",scalarProduct);
                    //waitFor(1);
                    printf("data = %ld , ",i);
                    stop();
                    free(tabA);
                    free(tabB);
                }
            }
}

int main()
{
srand ( time(NULL) );
ScalarProduct();
return 0;
}

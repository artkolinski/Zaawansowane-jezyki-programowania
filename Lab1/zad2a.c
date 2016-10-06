#include <stdio.h>
#include <stdlib.h>

int main()
{
	int *ptr,*temp,size,i,sum=0;
	printf("Enter the size of the table : ");
		scanf("%d",&size);
	ptr = (int *)malloc(size*sizeof(int));
	temp = ptr;
	for(i=0;i < size;i++)
		{
			printf("Enter the Number %d : ",i);
			scanf("%d",ptr);
			sum+=*ptr;
			ptr++;
		}
	ptr = temp;
	printf("\nsum : %d\n",sum);
	free(temp);
    return 0;
}

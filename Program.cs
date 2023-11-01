#include <stdio.h>
#include <string.h>

#define MAX_LENGTH 1000

void createNewArray(char strings[][MAX_LENGTH], int n, char result[][MAX_LENGTH], int* resultSize) {
    *resultSize = 0;
    for (int i = 0; i < n; i++) {
        if (strlen(strings[i]) <= 3) {
            strcpy(result[*resultSize], strings[i]);
            (*resultSize)++;
        }
    }
}

int main() {
    char strings[MAX_LENGTH][MAX_LENGTH];
    int n;

    printf("Введите количество строк: ");
    scanf("%d", &n);

    printf("Введите строки:\n");
    for (int i = 0; i < n; i++) {
        scanf("%s", strings[i]);
    }

    char result[MAX_LENGTH][MAX_LENGTH];
    int resultSize;

    createNewArray(strings, n, result, &resultSize);

    printf("Результат:\n");
    for (int i = 0; i < resultSize; i++) {
        printf("%s\n", result[i]);
    }

    return 0;
}

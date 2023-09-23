# формула
k = [1,2,3,20]
l = 7
n = 5
m = 10
for i in range(len(k)):
    S = (2 * k[i] * l) + (k[i] * (k[i]+1) * m) + (2 * n * k[i])
    print(S)



#цикл
k = [1, 2, 3, 20]
for i in range(len(k)):
    k = [1, 2, 3, 20]
    m = 10
    n = 5
    l = 7
    k = k[i]
    for j in range(1):
        S = 2 * l * k + k * (k+1) * m + 2 * n * k
        print(S)



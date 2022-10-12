file = open('C:\\triangle.txt')
triangle = [i for i in file.read().split('\n')]
triangle.pop()
triangle = [[int(j) for j in i.split(' ')] for i in triangle]

for i in range(1, 100):
    triangle[i][0] += triangle[i - 1][0]
    triangle[i][i] += triangle[i - 1][i - 1]

for i in range(2, 100):
    for j in range(1, i):
        triangle[i][j] += max(triangle[i - 1][j - 1], triangle[i - 1][j])
print(max(triangle[99]))

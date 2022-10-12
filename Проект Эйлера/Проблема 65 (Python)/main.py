arrNums = [0 for i in range(100)]
arrNums[0] = 2
k = 1

for i in range(1, 100, 3):
    arrNums[i] = 1
    arrNums[i + 1] = 2 * k
    arrNums[i + 2] = 1
    k += 1

numenator = denominator = 1
temp = 0

for i in range(98, 0, -1):
    numenator += (denominator * arrNums[i])
    numenator, denominator = denominator, numenator

numenator += 2 * denominator
print(sum([int(i) for i in str(numenator)]))
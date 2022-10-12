txt = [int(i) for i in open('C:\\cipher.txt').read().split(',')]
# TODO: Ищем возможные пароли

# s = []
# boo = True
# for a in range(97, 123):
#     for b in range(97, 123):
#         for c in range(97, 123):
#             s = []
#             for i in range(0, 1455, +3):
#                 s.append(txt[i] ^ a)
#                 s.append(txt[i + 1] ^ b)
#                 s.append(txt[i + 2] ^ c)
#             boo = True
#             for i in s:
#                 if ((i >= 32 and i <= 63) or (i >= 65 and i <= 122)):
#                     continue
#                 #print(i)
#                 boo = False
#                 break
#             if boo:
#                 print(a, b, c)

# TODO: Ручная проверка паролей

# for i in range(0, 1455, +3):
#     print(chr(txt[i] ^ 101), end='')
#     print(chr(txt[i + 1] ^ 120), end='')
#     print(chr(txt[i + 2] ^112), end='')
# print()

# TODO: Пароль: 101 120 112

# TODO: Считаем сумму

sumNums = 0
for i in range(0, 1455, +3):
    sumNums += (txt[i] ^ 101)
    sumNums += (txt[i + 1] ^ 120)
    sumNums += (txt[i + 2] ^ 112)
print(sumNums)
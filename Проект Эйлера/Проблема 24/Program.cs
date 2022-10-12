using System;
using System.Collections.Generic;

namespace Проблема_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая миллионная лексикографическая перестановка цифр 0, 1, 2, 3, 4, 5, 6, 7, 8 и 9?");
            byte[] array = new byte[10];
            for (int i = 0; ;)
            {
                List<byte> arr = new List<byte>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (byte i1 = 0; i1 < arr.Count; i1++)
                {
                    array[0] = arr[i1];
                    arr.RemoveAt(i1);
                    for (byte i2 = 0; i2 < arr.Count; i2++)
                    {
                        array[1] = arr[i2];
                        arr.RemoveAt(i2);
                        for (byte i3 = 0; i3 < arr.Count; i3++)
                        {
                            array[2] = arr[i3];
                            arr.RemoveAt(i3);
                            for (byte i4 = 0; i4 < arr.Count; i4++)
                            {
                                array[3] = arr[i4];
                                arr.RemoveAt(i4);
                                for (byte i5 = 0; i5 < arr.Count; i5++)
                                {
                                    array[4] = arr[i5];
                                    arr.RemoveAt(i5);
                                    for (byte i6 = 0; i6 < arr.Count; i6++)
                                    {
                                        array[5] = arr[i6];
                                        arr.RemoveAt(i6);
                                        for (byte i7 = 0; i7 < arr.Count; i7++)
                                        {
                                            array[6] = arr[i7];
                                            arr.RemoveAt(i7);
                                            for (byte i8 = 0; i8 < arr.Count; i8++)
                                            {
                                                array[7] = arr[i8];
                                                arr.RemoveAt(i8);
                                                for (byte i9 = 0; i9 < arr.Count; i9++)
                                                {
                                                    array[8] = arr[i9];
                                                    arr.RemoveAt(i9);
                                                    for (byte i10 = 0; i10 < arr.Count; i10++)
                                                    {
                                                        array[9] = arr[i10];
                                                        i++;
                                                        if (i == 1000000)
                                                        {
                                                            Console.Write("Ответ: ");
                                                            for (byte n = 0; n < 10; n++)
                                                            {
                                                                Console.Write(array[n]);
                                                            }
                                                            Console.WriteLine();
                                                        }
                                                    }
                                                    arr.Add(array[8]);
                                                    arr.Sort();
                                                }
                                                arr.Add(array[7]);
                                                arr.Sort();
                                            }
                                            arr.Add(array[6]);
                                            arr.Sort();
                                        }
                                        arr.Add(array[5]);
                                        arr.Sort();
                                    }
                                    arr.Add(array[4]);
                                    arr.Sort();
                                }
                                arr.Add(array[3]);
                                arr.Sort();
                            }
                            arr.Add(array[2]);
                            arr.Sort();
                        }
                        arr.Add(array[1]);
                        arr.Sort();
                    }
                    arr.Add(array[0]);
                    arr.Sort();
                }
            }
        }
    }
}

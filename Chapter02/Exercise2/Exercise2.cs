//formatting is hard
Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
Console.WriteLine(format: "Type {0,12} {1,30} {2, 61}", arg0: "Byte(s)", arg1: "Min", arg2: "Max");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
Console.WriteLine(format: "sbyte {0,8} {1,33} {2, 61}", arg0: sizeof(sbyte), arg1: sbyte.MinValue, arg2: sbyte.MaxValue);
Console.WriteLine(format: "byte {0,9} {1,33} {2, 61}", arg0: sizeof(byte), arg1: byte.MinValue, arg2: byte.MaxValue);
Console.WriteLine(format: "short {0,8} {1,33} {2, 61}", arg0: sizeof(short), arg1: short.MinValue, arg2: short.MaxValue);
Console.WriteLine(format: "ushort {0,7} {1,33} {2, 61}", arg0: sizeof(ushort), arg1: ushort.MinValue, arg2: ushort.MaxValue);
Console.WriteLine(format: "int {0,10} {1,33} {2, 61}", arg0: sizeof(int), arg1: int.MinValue, arg2: int.MaxValue);
Console.WriteLine(format: "uint {0,9} {1,33} {2, 61}", arg0: sizeof(uint), arg1: uint.MinValue, arg2: uint.MaxValue);
Console.WriteLine(format: "long {0,9} {1,33} {2, 61}", arg0: sizeof(long), arg1: long.MinValue, arg2: long.MaxValue);
Console.WriteLine(format: "ulong {0,8} {1,33} {2, 61}", arg0: sizeof(ulong), arg1: ulong.MinValue, arg2: ulong.MaxValue);
Console.WriteLine(format: "float {0,8} {1,33} {2, 61}", arg0: sizeof(float), arg1: float.MinValue, arg2: float.MaxValue);
Console.WriteLine(format: "double {0,7} {1,33} {2, 61}", arg0: sizeof(double), arg1: double.MinValue, arg2: double.MaxValue);
Console.WriteLine(format: "decimal {0,6} {1,33} {2, 61}", arg0: sizeof(decimal), arg1: decimal.MinValue, arg2: decimal.MaxValue);

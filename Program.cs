using System;

char c = 'a';
string str = "new string";

byte b = 200;
short s = 1000;
int i = 20000000;
long l = 3000000000000;

sbyte sb = -100;
ushort us = 1000;
uint ui = 20000000;
ulong ul = 3000000000000;

long overFlowCheck = checked(long.MaxValue + l); // o comando checked não deixa dar stackoverflow


object obj = s; // Todas as classes herdem de object, ele é o tipo básico do C#
dynamic dy = 8;
dy = "hello world";


int[] arr = new int[10];
//int nulo = null; ints nao aceitam nulo como um valor
int? nulo = null;




Console.WriteLine("Hello, World!");

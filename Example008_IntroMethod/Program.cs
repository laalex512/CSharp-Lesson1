int a1=23;
int b1=26;
int c1=48;
int a2=15;
int b2=7;
int c2=84;
int a3=97;
int b3=12;
int c3=15;

int Max(int a,int b,int c) {
    int result=a;
    if (b>result) result=b;
    if (c>result) result=c;
    return result;
}

int max=Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3)
);
Console.WriteLine(max);
sing System.Security.Cryptography.X509Certificates;
Console.WriteLine("unesi dva broja");
string[] imput = Console.ReadLine().Split(" ");
int A = int.Parse(imput[0]);
int B  = int.Parse(imput[1]);
static int Euklidov_algoritam_rekurzimo(int A , int B)
{
    if(B == 0)
    {
        return A;
    }
    int manji = Math.Min(A, B);
    int veci = Math.Max(A, B);
    return Euklidov_algoritam_rekurzimo(manji,veci-manji);
}
static int Euklidov_algoritam_rekurzimo1(int A, int B)
{
    if (B == 0)
    {
        return A;
    }
    return Euklidov_algoritam_rekurzimo(B, A%B);
}

static int Euklidov_algoritam_inerativno(int A, int B)
{
    while (B > 0)
    {
        int temp = B;
        B = A % B;
        A = temp;
    }
    return A;
}
Console.WriteLine($"nzd brojeva {A} i {B} je {Euklidov_algoritam_rekurzimo(A, B)}");
Console.WriteLine($"nzd brojeva {A} i {B} je {Euklidov_algoritam_rekurzimo1(A, B)}");
Console.WriteLine($"nzd brojeva {A} i {B} je {Euklidov_algoritam_inerativno(A, B)}");

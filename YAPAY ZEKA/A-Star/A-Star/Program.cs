
void createroadMatrix2(int[,] roadMatrix)
{
    roadMatrix[0, 0] = 0;
    roadMatrix[0, 1] = 4;
    roadMatrix[0, 2] = 2;
    roadMatrix[0, 3] = 2;
    roadMatrix[0, 4] = 2;
    roadMatrix[0, 5] = 1;
    roadMatrix[0, 6] = 1;
    roadMatrix[0, 7] = 2;
    roadMatrix[0, 8] = 4;
    roadMatrix[0, 9] = 5;

    roadMatrix[1, 0] = 4;
    roadMatrix[1, 1] = 0;
    roadMatrix[1, 2] = 4;
    roadMatrix[1, 3] = 2;
    roadMatrix[1, 4] = 3;
    roadMatrix[1, 5] = 6;
    roadMatrix[1, 6] = 4;
    roadMatrix[1, 7] = 4;
    roadMatrix[1, 8] = 8;
    roadMatrix[1, 9] = 2;

    roadMatrix[2, 0] = 2;
    roadMatrix[2, 1] = 4;
    roadMatrix[2, 2] = 0;
    roadMatrix[2, 3] = 1;
    roadMatrix[2, 4] = 5;
    roadMatrix[2, 5] = 2;
    roadMatrix[2, 6] = 7;
    roadMatrix[2, 7] = 1;
    roadMatrix[2, 8] = 2;
    roadMatrix[2, 9] = 2;

    roadMatrix[3, 0] = 2;
    roadMatrix[3, 1] = 2;
    roadMatrix[3, 2] = 1;
    roadMatrix[3, 3] = 0;
    roadMatrix[3, 4] = 2;
    roadMatrix[3, 5] = 3;
    roadMatrix[3, 6] = 1;
    roadMatrix[3, 7] = 3;
    roadMatrix[3, 8] = 2;
    roadMatrix[3, 9] = 4;

    roadMatrix[4, 0] = 2;
    roadMatrix[4, 1] = 3;
    roadMatrix[4, 2] = 5;
    roadMatrix[4, 3] = 2;
    roadMatrix[4, 4] = 0;
    roadMatrix[4, 5] = 3;
    roadMatrix[4, 6] = 8;
    roadMatrix[4, 7] = 3;
    roadMatrix[4, 8] = 2;
    roadMatrix[4, 9] = 2;

    roadMatrix[5, 0] = 1;
    roadMatrix[5, 1] = 6;
    roadMatrix[5, 2] = 2;
    roadMatrix[5, 3] = 3;
    roadMatrix[5, 4] = 3;
    roadMatrix[5, 5] = 0;
    roadMatrix[5, 6] = 6;
    roadMatrix[5, 7] = 2;
    roadMatrix[5, 8] = 3;
    roadMatrix[5, 9] = 4;

    roadMatrix[6, 0] = 1;
    roadMatrix[6, 1] = 4;
    roadMatrix[6, 2] = 7;
    roadMatrix[6, 3] = 1;
    roadMatrix[6, 4] = 8;
    roadMatrix[6, 5] = 6;
    roadMatrix[6, 6] = 0;
    roadMatrix[6, 7] = 2;
    roadMatrix[6, 8] = 2;
    roadMatrix[6, 9] = 2;

    roadMatrix[7, 0] = 2;
    roadMatrix[7, 1] = 4;
    roadMatrix[7, 2] = 1;
    roadMatrix[7, 3] = 3;
    roadMatrix[7, 4] = 3;
    roadMatrix[7, 5] = 2;
    roadMatrix[7, 6] = 2;
    roadMatrix[7, 7] = 0;
    roadMatrix[7, 8] = 6;
    roadMatrix[7, 9] = 3;

    roadMatrix[8, 0] = 4;
    roadMatrix[8, 1] = 8;
    roadMatrix[8, 2] = 2;
    roadMatrix[8, 3] = 2;
    roadMatrix[8, 4] = 2;
    roadMatrix[8, 5] = 3;
    roadMatrix[8, 6] = 2;
    roadMatrix[8, 7] = 6;
    roadMatrix[8, 8] = 0;
    roadMatrix[8, 9] = 4;

    roadMatrix[9, 0] = 5;
    roadMatrix[9, 1] = 2;
    roadMatrix[9, 2] = 2;
    roadMatrix[9, 3] = 4;
    roadMatrix[9, 4] = 2;
    roadMatrix[9, 5] = 4;
    roadMatrix[9, 6] = 2;
    roadMatrix[9, 7] = 3;
    roadMatrix[9, 8] = 4;
    roadMatrix[9, 9] = 0;


}
void createflyMatrix2(int[,] roadMatrix)
{
    roadMatrix[0, 0] = 0;
    roadMatrix[0, 1] = 20;
    roadMatrix[0, 2] = 22;
    roadMatrix[0, 3] = 22;
    roadMatrix[0, 4] = 22;
    roadMatrix[0, 5] = 23;
    roadMatrix[0, 6] = 23;
    roadMatrix[0, 7] = 22;
    roadMatrix[0, 8] = 20;
    roadMatrix[0, 9] = 19;

    roadMatrix[1, 0] = 20;
    roadMatrix[1, 1] = 0;
    roadMatrix[1, 2] = 20;
    roadMatrix[1, 3] = 22;
    roadMatrix[1, 4] = 21;
    roadMatrix[1, 5] = 18;
    roadMatrix[1, 6] = 20;
    roadMatrix[1, 7] = 20;
    roadMatrix[1, 8] = 16;
    roadMatrix[1, 9] = 22;

    roadMatrix[2, 0] = 22;
    roadMatrix[2, 1] = 20;
    roadMatrix[2, 2] = 0;
    roadMatrix[2, 3] = 23;
    roadMatrix[2, 4] = 19;
    roadMatrix[2, 5] = 22;
    roadMatrix[2, 6] = 17;
    roadMatrix[2, 7] = 23;
    roadMatrix[2, 8] = 22;
    roadMatrix[2, 9] = 22;

    roadMatrix[3, 0] = 22;
    roadMatrix[3, 1] = 22;
    roadMatrix[3, 2] = 23;
    roadMatrix[3, 3] = 0;
    roadMatrix[3, 4] = 22;
    roadMatrix[3, 5] = 21;
    roadMatrix[3, 6] = 23;
    roadMatrix[3, 7] = 21;
    roadMatrix[3, 8] = 22;
    roadMatrix[3, 9] = 20;

    roadMatrix[4, 0] = 22;
    roadMatrix[4, 1] = 21;
    roadMatrix[4, 2] = 19;
    roadMatrix[4, 3] = 22;
    roadMatrix[4, 4] = 0;
    roadMatrix[4, 5] = 21;
    roadMatrix[4, 6] = 16;
    roadMatrix[4, 7] = 21;
    roadMatrix[4, 8] = 22;
    roadMatrix[4, 9] = 22;

    roadMatrix[5, 0] = 23;
    roadMatrix[5, 1] = 18;
    roadMatrix[5, 2] = 22;
    roadMatrix[5, 3] = 21;
    roadMatrix[5, 4] = 21;
    roadMatrix[5, 5] = 0;
    roadMatrix[5, 6] = 18;
    roadMatrix[5, 7] = 22;
    roadMatrix[5, 8] = 21;
    roadMatrix[5, 9] = 20;

    roadMatrix[6, 0] = 23;
    roadMatrix[6, 1] = 20;
    roadMatrix[6, 2] = 17;
    roadMatrix[6, 3] = 23;
    roadMatrix[6, 4] = 16;
    roadMatrix[6, 5] = 18;
    roadMatrix[6, 6] = 0;
    roadMatrix[6, 7] = 22;
    roadMatrix[6, 8] = 22;
    roadMatrix[6, 9] = 22;

    roadMatrix[7, 0] = 22;
    roadMatrix[7, 1] = 20;
    roadMatrix[7, 2] = 23;
    roadMatrix[7, 3] = 21;
    roadMatrix[7, 4] = 21;
    roadMatrix[7, 5] = 22;
    roadMatrix[7, 6] = 22;
    roadMatrix[7, 7] = 0;
    roadMatrix[7, 8] = 18;
    roadMatrix[7, 9] = 21;

    roadMatrix[8, 0] = 20;
    roadMatrix[8, 1] = 16;
    roadMatrix[8, 2] = 22;
    roadMatrix[8, 3] = 22;
    roadMatrix[8, 4] = 22;
    roadMatrix[8, 5] = 21;
    roadMatrix[8, 6] = 22;
    roadMatrix[8, 7] = 18;
    roadMatrix[8, 8] = 0;
    roadMatrix[8, 9] = 20;

    roadMatrix[9, 0] = 19;
    roadMatrix[9, 1] = 22;
    roadMatrix[9, 2] = 22;
    roadMatrix[9, 3] = 20;
    roadMatrix[9, 4] = 22;
    roadMatrix[9, 5] = 20;
    roadMatrix[9, 6] = 22;
    roadMatrix[9, 7] = 21;
    roadMatrix[9, 8] = 20;
    roadMatrix[9, 9] = 0;



}
void createvisitMatrix2(int[,] roadMatrix)
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            roadMatrix[i, j] = 0;
        }
    }
}
void controlItMatrix(int[,] matrix, int matrixSize, string type)
{
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            if (matrix[i, j] != matrix[j, i])
            {
                Console.WriteLine("----------> "+type+" matrisi yanlış girilmiştir : " + matrix[i, j] + " " + matrix[j, i]);
            }
        }
    }
}
int aStar(int[,] roadMatrix, int[,] flyMatrix, int[,] visitMatrix, int start, int end, int matrixSize)
{
    start = start - 1;
    end = end - 1;
    int toplamYol = 0;
    int tempRoad = 0;
    int biggestPath = 999999;
    int temp_i=0;
    int temp_j=start;
    int i = 0;
    int j = 0;
    for(i = 0; i< matrixSize; i++)
    {
        i = temp_j;
        for (j = 0; j< matrixSize; j++)
        {
            if(i != j && roadMatrix[i, j] + flyMatrix[j,end] <= biggestPath && visitMatrix[i,j]==0 && visitMatrix[j,i]==0  && roadMatrix[i, j] !=0)
            {
                biggestPath = roadMatrix[i, j] + flyMatrix[j, end];
                temp_j = j;
                temp_i = i;
                tempRoad = roadMatrix[i, j];
            }
        }
        toplamYol += tempRoad;
        visitMatrix[temp_i, temp_j] = -1;
        visitMatrix[temp_j, temp_i] = -1;
        
        if (temp_j == end)
        {
            break;
        }
        if (i == matrixSize-1)
        {
            i = 0;
        }
    }
    return toplamYol;
}
void getMinimumPenalty(string x, string y, int pxy, int pgap)
{
    int i, j;

    int m = x.Length;
    int n = y.Length;

    int[,] dp = new int[n + m + 1, n + m + 1];
    for (int q = 0; q < n + m + 1; q++)
        for (int w = 0; w < n + m + 1; w++)
            dp[q, w] = 0;

    for (i = 0; i <= (n + m); i++)
    {
        dp[i, 0] = i * pgap;
        dp[0, i] = i * pgap;
    }

    for (i = 1; i <= m; i++)
    {
        for (j = 1; j <= n; j++)
        {
            if (x[i - 1] == y[j - 1])
            {
                dp[i, j] = dp[i - 1, j - 1];
            }
            else
            {
                dp[i, j] = Math.Min(Math.Min(dp[i - 1, j - 1] + pxy,
                                dp[i - 1, j] + pgap),
                                dp[i, j - 1] + pgap);
            }
        }
    }

    int l = n + m;

    i = m; j = n;

    int xpos = l;
    int ypos = l;

    int[] xans = new int[l + 1];
    int[] yans = new int[l + 1];

    while (!(i == 0 || j == 0))
    {
        if (x[i - 1] == y[j - 1])
        {
            xans[xpos--] = (int)x[i - 1];
            yans[ypos--] = (int)y[j - 1];
            i--; j--;
        }
        else if (dp[i - 1, j - 1] + pxy == dp[i, j])
        {
            xans[xpos--] = (int)x[i - 1];
            yans[ypos--] = (int)y[j - 1];
            i--; j--;
        }
        else if (dp[i - 1, j] + pgap == dp[i, j])
        {
            xans[xpos--] = (int)x[i - 1];
            yans[ypos--] = (int)'_';
            i--;
        }
        else if (dp[i, j - 1] + pgap == dp[i, j])
        {
            xans[xpos--] = (int)'_';
            yans[ypos--] = (int)y[j - 1];
            j--;
        }
    }
    while (xpos > 0)
    {
        if (i > 0) xans[xpos--] = (int)x[--i];
        else xans[xpos--] = (int)'_';
    }
    while (ypos > 0)
    {
        if (j > 0) yans[ypos--] = (int)y[--j];
        else yans[ypos--] = (int)'_';
    }

    int id = 1;
    for (i = l; i >= 1; i--)
    {
        if ((char)yans[i] == '_' && (char)xans[i] == '_')
        {
            id = i + 1;
            break;
        }
    }
    Console.WriteLine("The aligned genes are :\n");
    for (i = id; i <= l; i++)
    {
        Console.Write((char)xans[i] + "  ");
    }
    Console.Write("\n");
    for (i = id; i <= l; i++)
    {
        Console.Write((char)yans[i] + "  ");
    }
    return;
}
void getMinimumPenalty2(string x, string y, int pxy, int pgap)
{
    int i, j;

    int m = x.Length;
    int n = y.Length;

    int[,] dp = new int[n + m + 1, n + m + 1];
    for (int q = 0; q < n + m + 1; q++)
        for (int w = 0; w < n + m + 1; w++)
            dp[q, w] = 0;

    for (i = 0; i <= (n + m); i++)
    {
        dp[i, 0] = i * pgap;
        dp[0, i] = i * pgap;
    }

    for (i = 1; i <= m; i++)
    {
        for (j = 1; j <= n; j++)
        {
            if (x[i - 1] == y[j - 1])
            {
                dp[i, j] = dp[i - 1, j - 1];
            }
            else
            {
                dp[i, j] = Math.Min(Math.Min(dp[i - 1, j - 1] + pxy,
                                dp[i - 1, j] + pgap),
                                dp[i, j - 1] + pgap);
            }
        }
    }

    int l = n + m;

    i = m; j = n;

    int xpos = l;
    int ypos = l;

    int[] xans = new int[l + 1];
    int[] yans = new int[l + 1];

    while (!(i == 0 || j == 0))
    {
        if (x[i - 1] == y[j - 1])
        {
            xans[xpos--] = (int)x[i - 1];
            yans[ypos--] = (int)y[j - 1];
            i--; j--;
        }
        else if (dp[i - 1, j - 1] + pxy == dp[i, j])
        {
            xans[xpos--] = (int)x[i - 1];
            yans[ypos--] = (int)y[j - 1];
            i--; j--;
        }
        else if (dp[i - 1, j] + pgap == dp[i, j])
        {
            xans[xpos--] = (int)x[i - 1];
            yans[ypos--] = (int)'_';
            i--;
        }
        else if (dp[i, j - 1] + pgap == dp[i, j])
        {
            xans[xpos--] = (int)'_';
            yans[ypos--] = (int)y[j - 1];
            j--;
        }
    }
    while (xpos > 0)
    {
        if (i > 0) xans[xpos--] = (int)x[--i];
        else xans[xpos--] = (int)'_';
    }
    while (ypos > 0)
    {
        if (j > 0) yans[ypos--] = (int)y[--j];
        else yans[ypos--] = (int)'_';
    }

    int id = 1;
    for (i = l; i >= 1; i--)
    {
        if ((char)yans[i] == '_' && (char)xans[i] == '_')
        {
            id = i + 1;
            break;
        }
    }
    Console.Write("\n");
    for (i = id; i <= l; i++)
    {
        Console.Write((char)yans[i] + "  ");
    }
    return;
}

int[,] roadMatrix2 = new int[10, 10];
int[,] flyMatrix2 = new int[10, 10];
int[,] visitMatrix2 = new int[10, 10];

string gen1 = "AGCATTACGGT";
string gen2 = "ACCAAGTTACC";
string gen3 = "GGGGAATCTCC";
string gen4 = "CDDDEGGAGGC";
string gen5 = "GAAGGGTCAGA";
string gen6 = "CCAACGTTCCG";
string gen7 = "GCAGGGTCTCG";
string gen8 = "AATCGGCACAC";
string gen9 = "ACTAAGAGAAC";
string genX = "CGTGTGATGAT";
Console.WriteLine(gen1);
Console.WriteLine(gen2);
Console.WriteLine(gen3);
Console.WriteLine(gen4);
Console.WriteLine(gen5);
Console.WriteLine(gen6);
Console.WriteLine(gen7);
Console.WriteLine(gen8);
Console.WriteLine(gen9);
Console.WriteLine(genX);

createvisitMatrix2(visitMatrix2);
createroadMatrix2(roadMatrix2);
createflyMatrix2(flyMatrix2);
controlItMatrix(roadMatrix2, 10, "Yol");
controlItMatrix(flyMatrix2, 10, "Uçuş");

int []dizi=new int[10];
for(int i = 0; i < dizi.Length; i++)
{
    dizi[i]=0;
}
int x, z,counter=-99999,max;
for (x = 1; x <= 10; x++)
{
    for (z = 1; z <=10; z++)
    {
        if (x != z)
        {
            max = aStar(roadMatrix2, flyMatrix2, visitMatrix2, x, z, 10);
            createvisitMatrix2(visitMatrix2);
            dizi[x-1] = dizi[x-1] + max;
        }

    }
}

int alfa=0;
int dizike;

for (dizike = 0; dizike < 10; dizike++)
{
    if(dizi[dizike] > counter)
    {
        counter=dizi[dizike];
        alfa=dizike;
    }

}
Console.WriteLine("Merkez dizimiz:"+(alfa+1)+". dizidir\n");

int misMatchPenalty = 3;
int gapPenalty = 2;
getMinimumPenalty(gen2, gen1, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen3, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen4, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen5, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen6, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen7, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen8, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, gen9, misMatchPenalty, gapPenalty);
getMinimumPenalty2(gen2, genX, misMatchPenalty, gapPenalty);
Console.Write("\n\n\n\n");







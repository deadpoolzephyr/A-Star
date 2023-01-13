
using System;

class GFG
{
	public static void getMinimumPenalty(string x, string y, int pxy, int pgap)
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

		Console.Write("Minimum Penalty in aligning the genes = " + dp[m, n] + "\n");
		Console.Write("The aligned genes are :\n");
		for (i = id; i <= l; i++)
		{
			Console.Write((char)xans[i]);
		}
		Console.Write("\n");
		for (i = id; i <= l; i++)
		{
			Console.Write((char)yans[i]);
		}
		return;
	}

	static void Main()
	{
		string gene1 = "ABCDTG";
		string gene2 = "AGGCADATCA";
				int misMatchPenalty = 3;
		int gapPenalty = 2;

		getMinimumPenalty(gene1, gene2,
			misMatchPenalty, gapPenalty);
	}}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyAlgorithmExample1
{
    /* 贪婪算法问题
     * 设有m台完全相同的机器运行n个独立的任务，运行任务i所需要的时间为ti，要求确定一个调度方案是的完成所有任务所需要的时间最短。
    假设任务已经按照其运行时间从大到小排序，算法基于最长运行时间作业优先的策略；按顺序先把每个1务分配到一台机器上，然后将剩余
    的任务一次放入最先空闲的机器。
     
     * 常量和变量说明:    
     * m:机器数。
     * n:任务数。
     * t[]：输入数组，长度为n，其中每个元素表示任务的运行时间，下标从0开始。
     * s[][]:二维数组，长度为m*n，下标从0开始，其中元素s[i][j]表示机器i运行的任务j的编号。
     * d[]：数组，长度为m其中元素d[i]表示机器i的运行时间，下标从0开始。
     * count[]:数组，长度为m，下标从0开始，其中元素count[i]表示机器i运行的任务数。
     * i：循环变量。
     * j：循环变量。
     * k：临时变量。
     * max：完成所有任务的时间。
     * min：临时变量。   */  
    

    class Program
    {
        const int m = 5, n = 12;
        int[] t = new int[n] { 20, 18, 16, 15, 12, 10, 9, 8, 6, 5, 3, 2 };
        int[,] s = new int[m, n];
        int[] d = new int[m];
        int[] count = new int[m];
        
        int Function()
        {
            int i = 0, j = 0, k = 0, max = 0;
            for (i = 0; i < m; i++)
            {
                d[i]=0;
                for (j = 0; j < n; j++)
                {
                    s[i,j] = 0;
                }
            }

            for (i = 0; i < m; i++)
            {
                s[i, 0] = i;
                d[i] = d[i] + t[i];
                count[i] = 1;
            }

            for (i = m; i < n; i++)
            {
                int min = d[0];
                k = 0;
                for (j = 1; j < m; j++)
                {
                    if (min > d[j])
                    {
                        min = d[j];
                        k = j;
                    }
                }
                s[k, 0] = i;
                count[k] += 1;
                d[k] += t[i];

                
            }
            for (i = 0; i < m; i++)
            {
                if (d[i] > max)
                {
                    max = d[k];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
             Program p=new Program();
             Console.WriteLine("运行结束所需时间：" + p.Function().ToString());
             Console.ReadKey();
        }
    }
}

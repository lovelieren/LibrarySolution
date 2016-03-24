using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackTrackingAlgorithm
{
    class Queen
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             
        }
                
        int[] row = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
        int[] column = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
        List<Queen> queenList = new List<Queen>();

        void InitialQueen()
        {
            queenList.Clear();
            for (int i = 0; i < 8; i++)
            {
                Queen queen = new Queen();
                queen.Name = "Queen" + i.ToString();
                queenList.Add(queen);
            }
        }

        /// <summary>
        /// 回溯算法解决八皇后问题
        /// </summary>
        public void EightQueen()
        {
            for (int i = 0; i < row.Length; i++)
            {
                //
            }

        }


        /// <summary>
        /// 回溯算法
        /// 该算法相当于对穷举算法的巧妙实现
        /// N个点确定在每一对点间的N(N-1)/2个形如|Xi-Xj|(i≠j)的距离
        /// </summary>
        //public void BackingTracking()
        //{
        //    int[] Distance = new int[15] { 1, 2, 2, 2, 3, 3, 3, 4, 5, 5, 5, 6, 7, 8, 10 };
        //    int[] X;
        //}
    }
}
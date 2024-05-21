using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Matrix
    {
        public int  [,] Value;

        public Matrix(int size,int start,int end)
        {
            Value = new int[size, size];
            Random r = new Random();
            for(int i =0;i<Value.GetLength(0);i++)
            {
                for(int j = 0;j<Value.GetLength(1);j++)
                {
                    Value[i, j] = r.Next(start,end);
                }
            }
            
        }

        public Matrix(int size)
        {
            Value= new int[size,size];
        }
        public void Print()
        {
            for(int i =0; i < Value.GetLength(0); i++)
            {
                for (int j = 0; j<Value.GetLength(1); j++)
                {
                    Console.Write(Value[i, j] + "\t");
                }
                Console.WriteLine();    
            }
        }
        public int this[int rows,int cols]
        {
            get
            {
                if (rows >= 0 && rows <= Value.GetLength(0) && cols >= 0 && cols >= Value.GetLength(1))
                {
                    return Value[rows, cols];
                }
                throw new IndexOutOfRangeException();
            }
            set { Value[rows, cols] = value; }
            
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix result = new Matrix(A.Value.GetLength(0));
            for (int i = 0; i < A.Value.GetLength(0); ++i)
                for (int j = 0; j < A.Value.GetLength(1); ++j)
                    result.Value[i, j] = A.Value[i, j] + B.Value[i, j];
            return result;
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix result = new Matrix(A.Value.GetLength(0));
            for (int i = 0; i < A.Value.GetLength(0); ++i)
                for (int j = 0; j < A.Value.GetLength(1); ++j)
                    result.Value[i, j] = A.Value[i, j] - B.Value[i, j];
            return result;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix result = new Matrix(A.Value.GetLength(0));
            for (int i = 0; i < A.Value.GetLength(0); ++i)       
                for (int j = 0; j < B.Value.GetLength(1); ++j)
                    for (int k = 0; k < B.Value.GetLength(0); ++k)
                        result.Value[i, j] += A.Value[i, k] * B.Value[k, j];
            return result;
        }

        public static Matrix operator *(Matrix A, int num)
        {
            Matrix result = new Matrix(A.Value.GetLength(0));
            for (int i = 0; i < A.Value.GetLength(0); ++i)
                for (int j = 0; j < A.Value.GetLength(1); ++j)
                    result.Value[i, j] = num * A.Value[i, j];
            return result;
        }

        public static bool operator ==(Matrix A, Matrix B)
        {
            for (int i = 0; i < A.Value.GetLength(0); ++i)
                for (int j = 0; j < A.Value.GetLength(1); ++j)
                    if (A.Value[i, j] != B.Value[i, j])
                        return false;
            return true;
        }

        public static bool operator !=(Matrix A, Matrix B)
        {
            for (int i = 0; i < A.Value.GetLength(0); ++i)
                for (int j = 0; j < A.Value.GetLength(1); ++j)
                    if (A.Value[i, j] != B.Value[i, j])
                        return true;
            return false;
        }

        public override bool Equals(object ? A)
        {
            if (A is Matrix other)
                for (int i = 0; i < other.Value.GetLength(0); ++i)
                    for (int j = 0; j < other.Value.GetLength(1); ++j)
                        if (this.Value[i, j] == other.Value[i, j])
                            return true;
            return false;
        }



    }
}

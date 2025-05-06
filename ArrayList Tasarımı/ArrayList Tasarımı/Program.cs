using System;


namespace ArrayList_Tasarımı
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList a1 = new MyArrayList();
            a1.Add(5);
            a1.Add(6);
            a1.Add(7);
            a1.Add(8);
            a1.Add(9);
           a1.Add("mert");
            a1.Insert(3, "emin");
            a1.RemoveAt(5);

            string a = a1.toString();
            Console.WriteLine(a);
            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Get(2));
            string number = Console.ReadLine();




        }



    }

}


class MyArrayList
{

    public MyArrayList()
    {
        dizi = new object[4];
    }

    private object[] dizi;

    private int count = 0;
    public int Count
    {
        get { return count ; }
        set { count = value; }

    }

    private void DiziUzat()
    {
        object[] temp = new object[dizi.Length + 1];
        for (int i = 0; i < dizi.Length; i++)
        {
            temp[i] = dizi[i];

        }
        dizi = temp;

    }
    public void Add(object item)
    {
        DiziUzat();
        dizi[count] = item;
        count++;


    }


    public void Insert(int index, object item)
    {
        DiziUzat();
        for (int i = count ; i >index ; i--)
        {
            dizi[i] = dizi[i - 1];
        }
        dizi[index] = item;
        count++;


    }


    public void RemoveAt(int index)
    {

        for (int i = index ; i < count -1; i++)
        {
            dizi[i] = dizi[i + 1];

        }
        dizi[count - 1] = null;
        count--;




    }

    public object Get(int index)
    {

        return dizi[index];
    }

    public String toString()
    {
        String son = "";

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] != null)
            {
                son = son + "," + dizi[i];
            }
        }
        return son;
    }




}


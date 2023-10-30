using System.Net;

class garden{

    static int [,] pole;
    static void Main(){

        pole = new int [10,10];

        Thread A = new Thread(gardenerA);
        Thread B = new Thread(gardenerB);

        A.Start();
        B.Start();
        A.Join();
        B.Join();

          for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Console.Write(pole[i, a] + " ");
                }
                Console.WriteLine();
            }


    }

    static void gardenerA(){
        for(int i = 0; i < 10; i++ ){
            for(int a = 0; a < 10; a ++){
                if(pole[i,a] == 0){
                    pole[i,a] = 1;
                }
                Thread.Sleep(1);
            }
        }
    }

    static void gardenerB(){
        for(int i = 10 - 1; i > 0; i--){
            for(int b = 10 - 1; b > 0; b--){
                if(pole[i,b] == 0){
                    pole[i,b]= 2;
                }
                Thread.Sleep(1);
            }
        }
    }



}
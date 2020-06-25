
        
using System;

namespace ex24
{
    public class Tribonnaci
    {                               
        public Tribonnaci(int vezes){
            
            
            
               
            int t1=0;
            int t2=0;
            int t3=1;
            int tn;
            
           
            
            for (int i =0;i<vezes;i++){ 
                tn = t1+t2+t3;
                
                Console.WriteLine(tn);
                t1=t2;
                t2=t3;
                t3=tn;
                
                
            }
            
            
        }
        // public int trib(int n1,int n2,int n3,int vezes){
        //     int res;
        //     if(vezes>0){
        //         trib(res,,1,vezes-1);
        //         res=n1 + n2 + n3;
        //     }
        //     // Mano recursividade q ele ensinou hj ia ajudar 
        //     // Vamo la
        // }
   }              //VAMO LIGA FICA MAIS FACIL
}
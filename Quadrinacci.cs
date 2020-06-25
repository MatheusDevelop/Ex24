
        
using System;

namespace ex24
{
    public class Quadrinacci
    {                               
        public Quadrinacci(int vezes){
            
            
            
               
            int t1=0;
            int t2=0;
            int t3=1;
            int t4=1;
            int tn;
            
           
            
            for (int i =0;i<vezes;i++){ 
                tn = t1+t2+t3+t4;
                
                Console.WriteLine(tn);
                t1=t2;
                t2=t3;
                t3=t4;
                t4=tn;
                
                
            }
            
            
        }
        
   }              
}
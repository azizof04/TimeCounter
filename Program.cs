public class Demo {
   public static void Main() {
      DateTime date1 = DateTime.Now;
      DateTime date2 = new DateTime(2023, 10, 27, 22, 10, 00);
      TimeSpan ts = date1 - date2;
      double tstm = ts.TotalMinutes;
      // Console.WriteLine("Difference " + tstm);
      int fulltstm;
      fulltstm = (int)tstm;
      Console.WriteLine("Difference " + fulltstm + "minutes")  ;


double count = tstm / 60 ;

int FullHour;
 
 FullHour = (int)count;
int day = FullHour/24;




 if (  tstm > 60 && tstm < 1440 ){
   System.Console.WriteLine(FullHour + " saat evvel paylasldi");
}  

   else if(FullHour > 24){
      System.Console.WriteLine(day +" gun evvel ");
}
else 
{
   System.Console.WriteLine(fulltstm + " Deqiqe evvel paylasildi");
} 
   }
}
  







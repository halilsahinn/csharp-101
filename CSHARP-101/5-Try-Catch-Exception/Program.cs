using System;

namespace _5_Try_Catch_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Metin1" + args[0]);
            }

            //Programın çalışması için yeterli bellek kalmadıysa oluşur.
            catch (OutOfMemoryException ex)
            {

                ExceptionHandler(ex);
            }
            //Stack (Yığın) bellek bölgesinin birden fazla metod için kullanılması durumunda oluşur.
            //Genellikle kendini çağıran metodların hatalı kullanılmasıyla meydana gelir.
            catch (StackOverflowException ex)
            {
                ExceptionHandler(ex);
            }

            //Bellekte yer ayrılmamış bir nesne üzerinden sınıfın üye
            //elemanlarına erişmeye çalışırken oluşur.
            catch (NullReferenceException ex)
            {
                ExceptionHandler(ex);
            }

            //Bir veri türüne kapasitesinden fazla veri yüklemeye çalışılırken oluşur.
            catch (OverflowException ex)
            {
                ExceptionHandler(ex);
            }

            //Tür dönüştürme operatörüyle geçersiz tür dönüşümü yapılmaya çalışıldığında oluşur.
            catch (InvalidCastException ex)
            {
                ExceptionHandler(ex);
            }

            // Bir dizinin olmayan elemanına erişilmeye çalışılırken fırlatılır.
            catch (IndexOutOfRangeException ex)
            {
                ExceptionHandler(ex);
            }

            //Bir dizinin elemanına yanlış türde veri atanmaya çalışılırken oluşur.
            catch (ArrayTypeMismatchException ex)
            {
                ExceptionHandler(ex);
            }
            //Sıfıra bölme yapıldığı zaman oluşur.
            catch (DivideByZeroException ex)
            {
                ExceptionHandler(ex);
            }
            //Hemen hemen matematikle ilgili tüm istisnaları yakalayabilir.
            catch (ArithmeticException ex)
            {
                ExceptionHandler(ex);
            }
            //Metodlara yanlış biçimde parametre verildiğinde oluşur.
            catch (FormatException ex)
            {
                ExceptionHandler(ex);
            }



            finally
            {
                Console.WriteLine("FİNAL AŞAMASI");
                Console.ReadLine();
            }


        }

        public static void ExceptionHandler(Exception ex)
        {
            //Console.WriteLine(ex.Message +" "+ ex.StackTrace 
            //+" "+ ex.InnerException +" "+ ex.GetType);

            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Source);
            Console.WriteLine(ex.TargetSite);
            Console.WriteLine(ex.Data);
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.HelpLink);
            Console.WriteLine(ex.HResult);
            Console.WriteLine(ex.StackTrace);


        }
    }
}

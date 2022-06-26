namespace MyLibs;
public class MyMetods
{
   public static double[] GetArrayFromString(string? arrayStr)
   {
      string[] mass = arrayStr!.Split(new char[] { ' ', ',', '*' }, StringSplitOptions.RemoveEmptyEntries);
      double[] result = new double[mass.Length];
      for (int i = 0; i < mass.Length; i++)
      {
         result[i] = Convert.ToInt32(mass[i]);
      }
      return result;
   }
}

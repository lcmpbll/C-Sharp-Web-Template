namespace Parcel.Models
{
  public class ParcelVariable
  {
    public int Height { get; set; }
    public int Width {get; set; }
    public int Length {get; set; }
    public int Weight {get; set; }
    

    public ParcelVariable (int height, int width, int length, int weight )
     {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
      
     }

     public static int Volume (int height, int width, int length)
     {
     int Volume = height * width * length;

     return Volume;
     }

     public static int Cost(int height, int width, int length, int weight)
     {  int volume = Volume(height, width, length);
        int cost = 0;
        if(volume <= 77)
        {
          cost = weight * 30;
        }
        else if (volume > 300)
        {
          cost = weight * 35;
        }
        else
        {
          cost = weight * 33;
        }
        return cost;
     }
  }  

}




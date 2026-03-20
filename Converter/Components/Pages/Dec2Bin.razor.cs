namespace Converter.Components.Pages
{
    public partial class Dec2Bin
    {
        int dec = 0;
        string bin = "";
         void Calculate()
        {
           bin = Convert.ToString(dec, 2);
        }
    }
}

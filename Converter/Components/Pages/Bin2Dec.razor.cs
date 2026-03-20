namespace Converter.Components.Pages
{
    public partial class Bin2Dec
    {
        string bin = "";
        int dec = 0;
        void Calculate()
        {
            dec = Convert.ToInt32(bin, 2);
        }
    }
}

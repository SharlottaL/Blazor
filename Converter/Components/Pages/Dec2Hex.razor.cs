namespace Converter.Components.Pages
{
    public partial class Dec2Hex
    {
        int dec = 0;
        string hex = "";
        void Calculate()
        {
            hex = Convert.ToString(dec, 16).ToUpper();
        }
    }
}

namespace Converter.Components.Pages
{
    public partial class Hex2Dec
    {
        int num;
        string hexString = "";
        void Calculate()
        {
            num = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        }
    }
}

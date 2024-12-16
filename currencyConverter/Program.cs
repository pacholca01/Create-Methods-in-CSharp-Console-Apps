// For more info see 
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/3-exercise-create-methods-return-numbers

using System; 

double usd = 3.33;
double rate = 23500;
int vnd = ConvertUSDtoVND(usd);
double usdBackConverted = ConvertVNDtoUSD(vnd);

Console.WriteLine($"${usd} = {vnd} VND");
Console.WriteLine($"{vnd} VND = ${usdBackConverted}");

int ConvertUSDtoVND(double usdInput) {
    return (int) (rate * usd);
}

double ConvertVNDtoUSD(int vnd) {
    return vnd / rate;
}
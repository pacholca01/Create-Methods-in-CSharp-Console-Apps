// For more info see 
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/2-exercise-understand-return-type-syntax

/* 
Use methods to calculate the total purchase price

The Contoso Shopping Center is having a super sale! Many items have discounted price. You're given a list of item prices and a list of corresponding discounts. The discounts are represented by percentages, for example 50% = 0.5. If a customer spends more than
5.00 of their total purchase. In this task, you'll write code to calculate the customer's total. Let's get started!
*/

double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++) {
    total += GetDiscountedPrice(i);
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;
if (TotalMeetsMinimum()) {
    total -= 5.00;
    Console.WriteLine($"Total after discount: ${FormatDecimal(total)}");
}

double GetDiscountedPrice(int itemIndex) {
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum() {
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input) {
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
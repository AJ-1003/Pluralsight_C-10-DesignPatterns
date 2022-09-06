using Bridge.Concrete_Implementor;
using Bridge.Refined_Abstractions;

Console.Title = "Bridge";

var noCoupn = new NoCoupon();
var oneEuroCoupon = new OneEuroCoupon();
var twoEuroCoupon = new TwoEuroCoupon();

var meatMenuNoCoupon = new MeatMenu(noCoupn);
Console.WriteLine($"Meat based menu, no coupon: {meatMenuNoCoupon.CalculatePrice()} euro.");

var meatMenuOneEuroCoupon = new MeatMenu(oneEuroCoupon);
Console.WriteLine($"Meat based menu, one euro coupon: {meatMenuOneEuroCoupon.CalculatePrice()} euro.");

var meatMenuTwoEuroCoupon = new MeatMenu(twoEuroCoupon);
Console.WriteLine($"Meat based menu, two euro coupon: {meatMenuTwoEuroCoupon.CalculatePrice()} euro.");

Console.WriteLine();

var vegetarianMenuNoCoupon = new VegetarianMenu(noCoupn);
Console.WriteLine($"Vegetarian based menu, no coupon: {vegetarianMenuNoCoupon.CalculatePrice()} euro.");

var vegetarianMenuOneEuroCoupon = new VegetarianMenu(oneEuroCoupon);
Console.WriteLine($"Vegetarian based menu, one euro coupon: {vegetarianMenuOneEuroCoupon.CalculatePrice()} euro.");

var vegetarianMenuTwoEuroCoupon = new VegetarianMenu(twoEuroCoupon);
Console.WriteLine($"Vegetarian based menu, two euro coupon: {vegetarianMenuTwoEuroCoupon.CalculatePrice()} euro.");

Console.ReadLine();
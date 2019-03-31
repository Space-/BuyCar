topic: https://www.codewars.com/kata/buying-a-car/train/csharp

Priority sequence explanation:
(priority 1)At first, if price of old car > new car, sell old car to buy new car directly.
(priority 2)At the start of each month, both of new car and old cars' price will decrease 1.5 percent. (include month 0)
(priority 3)Furthermore the decreasing percent of loss increases by 0.5 percent at the end of every two months.( that means: "1.5% + 0.5% * ((int)(period  of Month / 2))" )
(priority 4)Selling, buying and saving are normally done at the end of each month.

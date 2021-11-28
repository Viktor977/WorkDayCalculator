# WorkDayCalculator
To the method input you receive a:
1. start date,
2. duration in days (whole number) and
3. weekends (array of objects with the fields "start date" and "end date")
If "start date" is the same with the "end date", it means the weekend happens only on that day. If "start date" isn't same with the "end date", it means that the whole period is a weekend.
Example.

23/04/2021 - 25/04/2021, two weekends (Saturday and Sunday) and 25th is a holiday, 3 weekends in total.
The array is sorted by the start date, periods do not intersect.
At the end the function should return the date, which is counted as a start date + duration, without weekends. Start date is the first day of the period.
Investigate and take into account all possible intersections of startdate, duration and weekend

Example 1.

Start date: 21/04/2021
Duration: 5 days
Weekends: 23/04/2021 - 25/04/2021
At the exit there should be: End date 28/04/2021
Explanation
1st day = 21.04.2021
2nd day = 22.04.2021
23.04.2021 excluded as weekend 24.04.2021 excluded as weekend 25.04.2021 excluded as weekend 3rd day = 26.04.2021
4th day = 27.04.2021
5th day = 28.04.2021

Example 2.

Start date: 21/04/2021
Duration: 5 days
Weekends 1: 23/04/2021 - 25/04/2021
Weekends 2: 29/04/2021 - 29/04/2021
At the exit there should be: End date 28/04/2021
Explanation
1st day = 21.04.2021
2nd day = 22.04.2021
23.04.2021 excluded as weekend 24.04.2021 excluded as weekend 25.04.2021 excluded as weekend 3rd day = 26.04.2021
4th day = 27.04.2021
5th day = 28.04.2021
Second weekend is not taken to account because duration ended before weekend
Implement method Calculate in class WorkDayCalculator in project CSharpTest delivered with test
Execute test methods to ensure you done logic correctly.
Add other tests you think are meningfull to verify all possible scenarious for function call.
* As a sample, you are given only 3 test cases. You can think over all the exceptions that may be by analogy.

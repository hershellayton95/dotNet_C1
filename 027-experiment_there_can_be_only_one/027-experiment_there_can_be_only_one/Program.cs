/*
There is a crucial difference between FirstOrDefault and SingleOrDefault.
If I only want 1 item, and want to make sure that is the only item with that value, which do I use?
Play around with both methods to see the differences.

*/

var oneElementList = new List<string>() {"list1-1"};
var twoElementList = new List<string>() {"list2-1", "list2-2"};

Console.WriteLine(oneElementList.FirstOrDefault());
Console.WriteLine(twoElementList.FirstOrDefault());

Console.WriteLine(oneElementList.SingleOrDefault());
Console.WriteLine(twoElementList.SingleOrDefault());
/*
* If I only want 1 item, and want to make sure that is the only item with that value, which do I use? Which one should you use, and why?
* Answar: SingleOrDefault.
* If there is only one element in the list and I want to ensure that there is only one element, 
* it's better to use the 'SingleOrDefault' method because it throws an exception if there is more than one element.
*/
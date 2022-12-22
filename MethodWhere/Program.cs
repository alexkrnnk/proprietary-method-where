using MyCollection;

var list = new List<int> { 1, 2, 3, 4 };

var oddQuery = list.MyWhere(i => i % 2 != 0);

list.Add(5);
var filterredList = oddQuery.ToList();

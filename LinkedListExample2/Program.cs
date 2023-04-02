using LinkedListExample2;

var list = new LinkedListClass();
list.Top = list.Insert(0, list.Top);
list.Top = list.Insert(1, list.Top);
list.Top = list.Insert(2, list.Top);
list.Top = list.Insert(3, list.Top);

list.Print(list.Top);

public class Program
{
    public static void Main()
    {
        //исходная строка символов
        string input = "a&b&c&d&e";

        //создание двусвязного списка из строки
        LinkedList<char> list = new LinkedList<char>(input.ToCharArray());

        //удаление элементов после &
        Udalenie(list);

        //вывод результата
        Console.WriteLine(string.Join(" ", list));
    }

    static void Udalenie(LinkedList<char> list)
    {
        LinkedListNode<char> current = list.First;
        while (current != null)
        {
            if (current.Value == '&')
            {
                LinkedListNode<char> nextNode = current.Next; //сохраняем следующий узел т.к. current может быть удален
                if (nextNode != null)
                {
                    list.Remove(nextNode); //удаляем следующий за & элемент
                }
            }

            current = current.Next;  //переходим к следующему элементу
        }
    }
}



//Add Two Numbers (Number #2 on Leetcode)

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) { //crea dos linked lists 
   
    ListNode head = null, tail = null;//crea un linked list para el resulatdo
    int remainder = 0; // se usa para el proceso de "carry the one" en suma de papel

    while (l1 != null || l2 != null || remainder != 0) 
    {
        int total = remainder;

        if (l1 != null)
        {
            total += l1.val; //sums the first digit
            l1 = l1.next; //thank you, next
        }

        if (l2 != null)
        {
            total += l2.val; //sums the first digit
            l2 = l2.next;//thank you, next
        }

        ListNode newNode = new ListNode(total % 10); //crea el last digit usando el remainder, o el digito a la derecha para añadirlo a la lista

        if (head == null)
        {
            head = tail = newNode;//mueve el tail al principio como head, y crea espacio para otro num (newnode) 
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        remainder = total / 10; //calcula el reciduo
    }

    return head; //devuele el list con el resultado
}
    }

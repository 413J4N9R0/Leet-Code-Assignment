// Word Ladder (Number #127 on Leetcode)

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
         Dictionary<string, List<string>> Words = new Dictionary<string, List<string>>(); //Diccionario para guardar las palabras

    foreach (string word in wordList)
    {
        for (int i = 0; i < word.Length; i++)
        {
            string match = word.Substring(0, i) + "*" + word.Substring(i + 1);// Si encuentra un match, reemplaza la letra con * 

            if (!Words.ContainsKey(match))
                Words[match] = new List<string>(); //Si una palabra no se encuentra con un match del previo, crea una lista aparte

            Words[match].Add(word); // añade la palabra a la lista 
        }
    }

    Queue<string> queue = new Queue<string>(); //Usa un queue (FIFO) ya que se esta utilizando un Breadth First Search
    queue.Enqueue(beginWord); 

    HashSet<string> visited = new HashSet<string> { beginWord }; // Se crea un hashset para evitar repetir palabras

    int steps = 1; //se utilizan steps ya que BFS y hace search por niveles

    while (queue.Count > 0)
    {
        int size = queue.Count;//declara cuantas palabras hay por nivel

        for (int i = 0; i < size; i++)
        {
            string word = queue.Dequeue();//thank you, next

            if (word == endWord)
                return steps; //si llega al final, devuelve la cantidad de pasos  

            for (int j = 0; j < word.Length; j++)
            {
                string match = word.Substring(0, j) + "*" + word.Substring(j + 1); //busca matches entre las palabras y reemplaza con *

                if (!Words.ContainsKey(match))
                    continue;

                foreach (string nearMatch in Words[match]) //pasa por el hashset de word matches para llegar el resultado
                {
                    if (!visited.Contains(nearMatch)) 
                    {
                        visited.Add(nearMatch);//si no se ha visitado, se marca como visitado.
                        queue.Enqueue(nearMatch);
                    }
                }
            }
        }

        steps++; 
    }

    return 0;
    }
}

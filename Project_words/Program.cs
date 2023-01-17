// Код для поиска символа в массиве данных и тексте!
using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge {
    class Program {
        static void Main(string[] args) {
            // Это массив из текстовых данных
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };
            // Вводится буква или цифра. которую нужно найти
            string letter = Console.ReadLine();
            // Первый уровень поиска символа в словах массива, 
            // если символ найден, то происходит вывод слова на экран
            for (int i = 0; i < words.Length; i++) { 
                bool b = words[i].Contains(letter);
                if (b) {
                    Console.WriteLine(words[i]);
                }                                         
            }
            // Второй уровень объединяет все элементы массива в текст
            string text = "";
            for (int j = 0; j < words.Length; j++) {
                text = text + words[j] + " ";                
            }
            // Третий уровень повторно производит поиск символа
            int count = -1;
            for (int k = 0; k < text.Length; k++) {
                count = text.IndexOf(letter);                
            }
            // Если символ все таки не найден, то выводится сообщение "No match"
            if (count == -1) {
                Console.WriteLine("No match");  
            }                                       
        }
    }
}
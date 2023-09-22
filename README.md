# Примеры работы с операторами

<div align="center">
  <img src="https://media.giphy.com/media/3oKIPnAiaMCws8nOsE/giphy.gif" width="600" height="300"/>
</div>

## Инициализация переменных
1. Условные операторы
  + Конструкция if...else if...else (Проверка на четность)
  + Конструкция switch...case (Калькулятор)
3. Операторы перехода
  + break
  + continue (Вывести только нечетные числа из последовательности)
  + goto (Цикл)

---
Пример: выполнение задач, пока пользователь не введет символ e или E
```
            string input = String.Empty;
            do
            {
                Console.WriteLine("Введите номер примера:\n 1. If...else,\n " +
                "2. Switch,\n " +
                "3.Контролируемый цикл, \n " +
                "4.Continue, \n " +
                "5.Goto\nДля выхода нажмите e или E");

                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    NavigateMenu(result);
                }
                else
                {
                    Console.WriteLine("Не удалось преобразовать входные параметры");
                }
            }
            while (!(input.Equals("E") || input.Equals("e")));
```

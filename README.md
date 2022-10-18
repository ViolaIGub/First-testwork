# Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

# Решение:

* _создать алгоритм решения задачи в виде блок-схемы_;

* _описать словесно алгоритм решения задачи при помощи контроля версий_;

* _написать программу для решения задачи в С#_.

# 1. Блок-схема

В программе _draw.io_ оформили блок-схему. Рисунок снабдили началом и окончанием алгоритма соответствующими овальными терминаторами. 

Ввели исходные данные фигурой Данных. В исходные данные ввели заданный массив данных, новый массив, и условие для формирования нового массива - ширину единицы массива.

Блок-схема оформлена тремя циклами. Первый ищет в заданном массиве индексы шириной 3 символа. Второй - предназначен для формирования нового массива. Третий - для вывода на экран нового массива. 

Вывод на экран оформлен соответствующей фигурой.

# 2. Контроль версий
Создали папку для текстового описания алгоритма решения и ввели ее под под контроль программы _Git_. Создали файл _README.md_.

Далее создали репозиторий на сайте _GitHub_ и скоординировали работу локального и удаленного репозитория.

Позже создали 5 веток в файле _README.md_ для текстрового описания алгоритма решения поставленой задачи. Слили ветки. 

Окончательный вариант передали на сайт _GitHub_.

# 3. Решение задачи в С#
Создали папку, используя программу _VSCode_. Инициировали программу _С#_ командой _dotnet new console_.

Ввели текстовые данные идентификатором текстовых данных _""_.

Два цикла оформили командой _for_. Один - _if_.

Для нахождения индексов массива, соответствующим условию задачи, использовали опертор _{"текст", width: fmt}_.


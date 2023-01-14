# _**Leave strings of 3 letters**_
## Содержание
* [Функция программы](#Program)
* [Метод GetNumber](#GetNumber)
* [Метод FillArray](#FillArray)
* [Метод PrintArray](#PrintArray)
* [Метод CountThreeSymbolElements](#CountThreeSymbolElements)
* [Метод SortAndFillArray](#SortAndFillArray)
* [Тестировочные методы](#Test)

<a id="Program"> </a>
_**Leave strings of 3 letters**_ - это программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3-м символам.
***
### **Для реализации решения задачи мы используем следующие методы:**

<a id="GetNumber"> </a>
1. `GetNumber`. Данный метод запрашивает у пользователя число, проверяет, удовлетворяет ли оно требованиям (являются ли данные, введенные пользователем **числом** и **больше ли оно нуля**). Если требования не удовлетворены - "выбрасывает" `FormatException`[^1].
<a id="FillArray"> </a>
2. `FillArray`. Данный метод запрашивает у пользователя ввод каждого элемента массива и заполняет его.
<a id="PrintArray"> </a>
3. `PrintArray`. Данный метод выводит в консоль все элементы массива в кавычках и через запятую.
<a id="CountThreeSymbolElements"> </a>
4. `CountThreeSymbolElements`. Данный метод является одним из двух ключевых методов программы. Он считает количество элементов массива, длина которых меньше или равна 3. **Использование данного метода было необходимо для создания нового, "отсортированного" массива.**
<a id="SortAndFillArray"> </a>
5. `SortAndFillArray`. Данный метод - второй ключевой метод программы. Он проверяет длину каждого элемента исходного массива и заполняет нужными элементами новый массив.

<a id="Test"> </a>
Два крайних метода, которые мы не включили в список выше - это методы `TestCountThreeSymbolElements` и `TestSortAndFillArray`. Задача этих методов понятна из их названия - это проверить ключевые методы `CountThreeSymbolElements` и `SortAndFillArray`, и, в случае неправильной их работы, вывести соответствующее сообщение в консоль.

[^1]: Инициализирует новый экземпляр класса FormatException с указанным сообщением об ошибке.
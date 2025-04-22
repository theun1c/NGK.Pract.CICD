namespace NGK.Pract.CICD.Tests
{
    public class WorkWithStrTests
    {
        // Вложенный класс для тестирования метода FindAllOccurrences
        public class FindAllOccurrencesTests
        {
            [Fact]
            public void FindAllOccurrences_ShouldReturnEmptyArray_WhenSourceIsEmpty()
            {
                // Подготовка: пустая исходная строка и непустая подстрока
                string source = "";
                string substring = "test";

                // Действие: вызов тестируемого метода
                var result = WorkWithStr.FindAllOccurrences(source, substring);

                // Проверка: результат должен быть пустым массивом
                Assert.Empty(result);
                // Тест проверяет граничное условие - пустую входную строку
            }

            [Fact]
            public void FindAllOccurrences_ShouldReturnEmptyArray_WhenSubstringNotFound()
            {
                // Подготовка: строка, в которой точно нет искомой подстроки
                string source = "hello world";
                string substring = "xyz";

                // Действие: вызов метода поиска
                var result = WorkWithStr.FindAllOccurrences(source, substring);

                // Проверка: при отсутствии совпадений должен вернуться пустой массив
                Assert.Empty(result);
                // Тест проверяет случай, когда подстрока не найдена в исходной строке
            }
        }

        // Вложенный класс для тестирования метода ReplaceAll
        public class ReplaceAllTests
        {
            [Fact]
            public void ReplaceAll_ShouldReturnOriginal_WhenSourceIsEmpty()
            {
                // Подготовка: пустая исходная строка
                string source = "";
                string oldValue = "test";
                string newValue = "new";

                // Действие: попытка замены в пустой строке
                var result = WorkWithStr.ReplaceAll(source, oldValue, newValue);

                // Проверка: метод должен вернуть исходную (пустую) строку
                Assert.Equal(source, result);
                // Тест проверяет работу метода с пустой строкой
            }

            [Fact]
            public void ReplaceAll_ShouldReturnOriginal_WhenOldValueIsEmpty()
            {
                // Подготовка: пустая подстрока для замены
                string source = "test string";
                string oldValue = "";
                string newValue = "new";

                // Действие: попытка замены пустой подстроки
                var result = WorkWithStr.ReplaceAll(source, oldValue, newValue);

                // Проверка: метод должен вернуть исходную строку без изменений
                Assert.Equal(source, result);
                // Тест проверяет обработку случая с пустой заменяемой подстрокой
            }

            [Fact]
            public void ReplaceAll_ShouldReplaceAllOccurrences()
            {
                // Подготовка: строка с несколькими вхождениями подстроки
                string source = "cat dog cat bird cat";
                string oldValue = "cat";
                string newValue = "fish";
                string expected = "fish dog fish bird fish";

                // Действие: замена всех вхождений "cat" на "fish"
                var result = WorkWithStr.ReplaceAll(source, oldValue, newValue);

                // Проверка: все вхождения должны быть заменены
                Assert.Equal(expected, result);
                // Основной тест, проверяющий базовую функциональность замены
            }
        }

        // Вложенный класс для тестирования метода Reverse
        public class ReverseTests
        {
            [Fact]
            public void Reverse_ShouldReturnEmpty_WhenSourceIsEmpty()
            {
                // Подготовка: пустая строка
                string source = "";

                // Действие: попытка перевернуть пустую строку
                var result = WorkWithStr.Reverse(source);

                // Проверка: должна вернуться пустая строка
                Assert.Equal("", result);
                // Тест граничного условия для пустой строки
            }

            [Fact]
            public void Reverse_ShouldReturnOriginal_WhenSourceIsSingleChar()
            {
                // Подготовка: строка из одного символа
                string source = "a";

                // Действие: переворот строки из одного символа
                var result = WorkWithStr.Reverse(source);

                // Проверка: строка должна остаться неизменной
                Assert.Equal("a", result);
                // Тест особого случая - строка из одного символа
            }

            [Fact]
            public void Reverse_ShouldCorrectlyReverseString()
            {
                // Подготовка: обычная строка из нескольких символов
                string source = "abcdef";
                string expected = "fedcba";

                // Действие: переворот строки
                var result = WorkWithStr.Reverse(source);

                // Проверка: строка должна быть перевернута правильно
                Assert.Equal(expected, result);
                // Основной тест базовой функциональности метода Reverse
            }
        }
    }
}
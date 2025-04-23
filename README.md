# NGK.Pract.CICD - Библиотека для работы со строками

[![.NET CI](https://github.com/theun1c/NGK.Pract.CICD/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/theun1c/NGK.Pract.CICD/actions)

Библиотека предоставляет методы для обработки строк с юнит-тестами.

## Установка

Добавьте в проект через .NET CLI:
```bash
dotnet add package NGK.Pract.CICD
```

## Методы
FindAllOccurrences
``` csharp
public static int[] FindAllOccurrences(string source, string substring)
```
Находит все вхождения подстроки (регистрозависимо).
Возвращает массив индексов или пустой массив, если совпадений нет.

Пример:
``` csharp
var indices = WorkWithStr.FindAllOccurrences("hello world", "o"); // [4, 7]
```

ReplaceAll
``` csharp
public static string ReplaceAll(string source, string oldValue, string newValue, bool ignoreCase = false)
```
Заменяет все вхождения подстроки.
Параметр ignoreCase позволяет игнорировать регистр.

Пример:
``` csharp
var result = WorkWithStr.ReplaceAll("Foo Bar", "foo", "New", ignoreCase: true); // "New Bar"
```

Reverse
``` csharp
public static string Reverse(string source)
```
Переворачивает строку задом наперёд.

Пример:
``` csharp
var reversed = WorkWithStr.Reverse("12345"); // "54321"
```

## Тестирование
Локальный запуск тестов
``` bash
dotnet test NGK.Pract.CICD.Tests
```
Запуск конкретного теста
``` bash
dotnet test --filter "FullyQualifiedName~WorkWithStrTests.ReverseTests.Reverse_ShouldCorrectlyReverseString"
```

## CI/CD
Автоматическая сборка и тестирование через GitHub Actions

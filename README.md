Создать приложение на языке C# с БД MSSQL. 
Разработку вести с помощью системы контроля версий git
Приложение представляет из себя базу сотрудников организаций. 
Должно включать возможность:
1.	Заведения новой организации из интерфейса (Наименование, ИНН, юр. адрес, факт. адрес)
2.	Заведения сотрудников из интерфейса (Фамилия, Имя, Отчество, дата рождения, паспорт серия, паспорт номер)
3.	Иметь возможность импорта и экспорта из\в csv-файл

Репозиторий должен содержать:
1.	Проект, выполненный в visual studio
2.	Скрипт создания и первоначального заполнения базы данных
3.	Данные в csv для загрузки
4.	Пример выгрузки csv

Версия NET 8.0
Версия MSSQL server 2014 12.0.2000
Срипт create.bat содержит sqlcmd запрос с передачей параметра FullScriptDir  не смотря на то, что решение предложено mateuscb в 2014 году, а так же подтверждено water в 2016  https://stackoverflow.com/questions/139245/relative-path-in-t-sql
На моей версии сервера скрипт не запускается, т. к. %CD% передается как текст, а полный путь через переменную не подходит, т. к. sqlcmd -v  проверяет значения переменных на не допустимые символы windows \ : , избавиться от : в пути файла нет возможности.
Для запуска скрипта в CreateDB.sql надо указать точный адрес csv файла с данными.

# TaskManager

### Результат

https://github.com/oqo0/TaskManager/blob/master/assets/showcase.mp4

### Разработать приложение по следующим требованиям:  

- Разработать базу данных с тремя таблицами  
1. Задачи, содержит столбцы (`ID`, `Name`, `Description`, `Status_ID`)  
2. Статусы, содержит столбцы (`Status_ID`, `Status_name`). Необходимо создать 3 строки со значениями (Создана, В работе, Завершена).  
Идентификаторы придумать самостоятельно.  
- Разработать интерфейс отображающий:  
1. Вкладк Задачи, содержит саму таблицу "Задачи", кнопки "Добавить", "Удалить", "Редактировать".  
Должна быть возможность выделять строку для удаления или редактирования.  
Таблица "Задачи" должна визуально содержать следующие столбцы (Наименование(Name), Описание(Description), Статус (Значение поля `Status_name` из таблицы "Статусы", связь осуществляется по полю `Status_ID`)  
Кнопка "Добавить" - По нажатию на кнопку открывается форма добавления новой записи, заполняются данные и нажимается кнопка "Добавить", должна быть реализована проверка на заполненность всех полей.  
Кнопка "Удалить" - По нажатии на кнопку происходит удаление выделенной записи таблицы "Задачи", если не выбрана запись пользователь должен получить соответствующее сообщение.  
Кнопка "Редактировать" - По нажатию на кнопку открывается форма редактирования выделенной записи.  
  
На формах редактирования и добавления записи поле статус должно представлятьвыпадающий список со значениями поля (`Status_name`) из таблицы Статусы.  

### Необходимо использовать  
- Visual Studio 2019  
- NET Core 3.1  
- Решение должно использовать Web интерфейс  
- Для связи с БД необходимо использовать Entity Framework  
- Операции по получению, удалению и обновлению записей должны использовать API контроллеры и выполнены в виде вызова методов Web API. Для передачи данных необходимо использовать JSON.  
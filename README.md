# Веб-приложение "Вакансии"
___
## Описание проекта
Вакансии — это веб-приложение, предназначенное для облегчения процесса поиска работы и подбора персонала. Позволяющее работодателям публиковать и редактировать свои вакансии, просматривать отклики. А соискатели, в свою очередь, могут публиковать свои резюме, а также просматривать и откликаться на вакансии работодателей. Приложение поддерживает регистрацию с выбором типа пользователя (работодатель/соискатель) и авторизацию.
___
## Типы пользователей:

* Администратор: 
    * Может блокировать пользователей
    * Имеет доступ к списку всех (вакансий/резюме), проверяет, соответствуют ли (вакансии/резюме) правилам сайта
    * Может выделить вакансии в отдельную категорию (рекомендуемые)
    * Может удалять и редактировать записи
* Работодатель: 
    * Публикует вакансии
    * Просматривает и редактирует свои вакансии 
    * Просматривает резюме и отклики на вакансии
* Соискатель: 
    * Публикует резюме
    * Просматривает вакансии
    * Откликается на вакансии
___
## Функциональные требования
### 1. Регистрация работодателя
* Работодатель должен иметь возможность зарегистрироваться, указав:
    * Email
    * Пароль
    * Имя
    * Фамилию
    * Название компании
    * Сайт компании
    * Название должности (для подтверждения, что это работодатель)
* Соискатель должен иметь возможность зарегистрироваться, указав:
    * Email
    * Пароль
    * Имя
    * Фамилию
* Email должен быть уникальным
* При успешной регистрации пользователю на указанный адрес электронной почты высылается подтверждение

### 2. Логин, логаут пользователя
* Пользователь должен иметь возможность авторизоваться в приложение, указав:
    * Email
    * Пароль
* При входе в систему необходимо:
    * Проверить, существует ли учетная запись с указанным Email
    * Проверить правильность введенного пароля
* Пользователь должен иметь возможность выйти из веб-приложения, нажав кнопку "Логаут"

### 3. (INDEX) Просмотр списка записей
* В профиле пользователя будет представлен список опубликованных им записей
* Работодатель должен иметь доступ к списку резюме и к списку откликов на резюме
* Соискатель должен иметь доступ к списку вакансий
* Списки вакансий и резюме должены быть отсортированы по дате публикации (по умолчанию), а также должен быть доступен поиск по ключевым словам (название должности, компания и т. д.)

### 4. (CREATE) Создание записи
* Работодатель должен иметь возможность создавать новые вакансии
    * Каждая вакансия должна содержать:
        * Название должности
        * Краткое описание вакансии
        * Компанию
        * Город
        * Дату публикации
        * Опыт
        * Заработную плату
        * Дополнительные поля
* Соискатель должен иметь возможноть создавать новые резюме
    * Каждое резюме должно содержать:
        * Название желаемой должности
        * Образование
        * Опыт работы:
            * Название компании
            * Должность
            * Период работы
            * Описание обязанностей
            * Достижения
        * Навыки
        * Желаемую заработную плату
        * Дополнительные поля (ссылка на github)
* После заполнения всех полей и нажатия кнопки "Сохранить и опубликовать" запись будет добавлена в нужный список
### 5. (READ) просмотр деталей записи
* Пользователю предоставлено два списка на выбор (вакансии\резюме). При выборе вакансии или резюме из соответствующего списка пользователь попадает на страницу с деталями записи
* Страница вакансии должна отображать:
    * Название должности
    * Краткое описание вакансии
    * Компанию
    * Город
    * Дату публикации
    * Опыт
    * Заработную плату
    * Дополнительные поля
* Страница резюме должна отображать:
    * Название должности
    * Образование
    * Опыт работы:
        * Название компании
        * Должность
        * Период работы
        * Описание обязанностей
        * Достижения
    * Навыки
    * Pаработную плату
    * Дополнительные поля (ссылка на github)
* Для окончания просмотра записи и нажатия кнопки "Вернуться назад" пользователь попадает на страницу с соответствующим списком

### 6. (UPDATE) Редактирование записи
* В профиле пользователя будет представлен список опубликованных им записей. Выбрав нужную запись и нажав кнопку "Редактировать" пользователь может внести нужные ему изменения.
* Нажав кнопку "Сохранить" обновленная запись сохраняется
* Форма редактирования должна быть аналогична форме создания записи 

### 7. (DELETE) Удаление записи
* Выбрав нужную запись и нажав кнопку "Удалить" пользователь может удалить опубликованную запись
___
### Модель базы данных
![image](https://github.com/user-attachments/assets/f01b105b-10a7-4352-aa2c-386d677de121)


﻿# Правила гри
 Потрібно відповісти на запитання відгадавши зразу слово або по бувках.
 Якщо учасник зразу відгадає слово йому надається 150 балів, а за кожну правильно відгадану букву по 5 балів.
 В учасника є тільки 10 спроб.
# Методичні рекомендації до виконання лабораторних робіт з дисципліни Конструювання ПЗ

## Вступ

Термін "Конструювання ПЗ" запроваджений [Стівеном МакКоннеллом](https://en.wikipedia.org/wiki/Steve_McConnell) у його книзі ["Досконалий код"](https://en.wikipedia.org/wiki/Code_Complete). 

Дисципліна "Конструювання ПЗ" в основному стосується технік мінімізації складності ПЗ, що, у свою чергу, зменшить кількість помилок у ньому і підвищить гнучкість його адаптації до нових завдань. 

В рамках лабораторних робіт студенти вивчають техніки хорошого стилю коду: грамотне розмежування додатку на компоненти у пакетах чи просторах імен, ін'єкція залежностей, використання дизайн патернів, документування інтерфейсів на основі javadoc, XML documentation чи NDoc; 
написання юніт-тестів;
використання систем контролю версій.

Усі лабораторні роботи виконуються в рамках прилюдних репозиторіїв студентів. 
Дисципліна стосується новітніх технологій, тому вся документація і звіти з виконання лабораторних робіт зберігаються у виключно в репозиторіях. 

Друкувати паперові звіти з виконання лабораторних робіт не потрібно.

Дисципліна не стосується якоїсь конкретної мови програмування, технології чи середовища розробки. 
Вона надає практичні рекомендації, яких можна дотримуватися на буль-якій мові програмування.
Це відповідає терміну С.МакКоннелла "program into language" див. [тут](https://codeblog.jonskeet.uk/2008/04/23/programming-quot-in-quot-a-language-vs-programming-quot-into-quot-a-language/). 
Тому Ви вільні у виборі мови програмування, технології і середовища розробки.
Практичне завдання можна виконати як консольний чи віконний додаток для .NET або JVM, як веб-сторінку з JavaScript або будь-що інше за вподобанням студента.

Будь ласка, регулярно відправляйте у репозиторій проміжні версії своєї роботи. 
Бо дуже підозріло виглядає репозиторій, де студент відправив лише одну завершену версію програми в день виставлення залікового модуля.

Приємного програмування!

## Перше завдання

Створіть обліковий запис на [github](github.com).

Додайте у файл `README.md` розділ "Правила гри", де опишіть так, як пригадуєте з лекційного заняття, правила гри "Вгадай слово".

## Друге завдання 

Створіть у будь-якій мові програмування інтерфейс (трейт) `TaskProvider` з методом `get`, що повертає інстанцію `Task`.

Добавте структуру (кейс-клас) `Task` з полями `question` та `answer` стрічкового типу.

Створіть юніт-тест `TaskProviderTest` для компонента `TaskProvider`. Тест повинен перевіряти чи метод `get` повертає непорожню (not null) інстанцію `Task`, обидва поля якого також непорожні (not null).

Напишіть найпримітивнішу імплементацію `TaskProviderImpl` інтерфейсу `TaskProvider`.

## Третє завдання

Добавте інтерфейс `GameView` з методами `showSorry(message)`, `showCongratulations(message)`, `showCurrentGuess(guess: String)` та `showTask(task: Task)`.

Добавте інтерфейс `GameService` з властивостями `gameView: GameView`, `taskProvider: TaskProvider` та методами: `guessWord(word: String)`, `guessLetter(letter: String)` і `start()`.

Напишіть юніт-тест `GameServiceTest` для компоненту `GameService`, який засобами [Mockito](http://site.mockito.org/) підставляє імітаційні (mocked) імплементації компонентів `gameView: GameView` і `taskProvider: TaskProvider`. Тест повинен перевіряти чи компонент вірно опрацьовує логіку гри при вірно і невірно вгаданому слові(букві). При цьому слід перевіряти особливі випадки: користувач ввів порожню стрічку, користувач вгадав букву, котра у слові зустрічаєтсья двічі і т.д.

## Четверте завдання

Створіть нову імплементацію інтерфейсу `TaskProvider`, яка зчитує запитання і відповіді з файла чи будь-якого іншого засобу локального збереження даних, наприклад, [HTML5 Web Storage](https://www.w3schools.com/html/html5_webstorage.asp) для веб-додатків.

Добавте до `TaskProviderTest` юніт-тест, що перевіряє чи два послідовні звернення до методу `get` повертають різні завдання і чи адекватно опрацьовується випадок завершення файла (спроба отримати більше завдань ніж присутні у файлі).

Якщо ви розробляєте десктопний додаток, то зверніть увагу як ваш додаток виконує пошук файла із завданнями відносно поточної робочої директорії.

![Guess word game UML](https://raw.githubusercontent.com/pigovsky/guess-word-game/master/dia/kpz1.png)

## П'яте завдання 

Створіть ще одну імплементацію інтерфейсу `TaskProvider`, яка зчитує запитання і відповіді за допомогою get запиту на [REST ресурс](https://raw.githubusercontent.com/pigovsky/guess-word-game/master/tasks/all.json). 

Імплементація повинна переключатися на отримання даних з локального сховища при невдалій спробі отримання даних з вказаного ресурсу. Перевірте цю поведінку за допомогою юніт-тесту.

## Шосте завдання (КПІЗ)

Добавте в програму сутність `User` з полями, що описують його id (ціле число), адресу електронної пошти, ім'я, прізвище, стать, рік народження, рахунок у грі та хеш паролю. 

Добавте компонент-інтерфейс `UsersDao` з методами `add(user: User): User`, `findUser(email: String, passwordHash: String): User`, `all(): List<User>` та `update(user: User)`.

Напишіть юніт-тест для компоненту `UsersDao`.

Створіть примітивну імплементацію `UsersDaoInMemoryImpl` компоненту `UsersDao`, яка зберігає користувачів у пам'яті звичайнісінької колекції. Метод `add(user: User): User` повинен кожному наступному об'єкту присвоювати новий `id`, що на одиницю більший від попереднього.

Використайте розроблені компоненти у програмі.

![UsersDao uml](https://raw.githubusercontent.com/pigovsky/guess-word-game/master/dia/UsersDao.png)

## Сьоме завдання

Створіть імплементацію `UsersDaoSQLiteImpl` компоненту `UsersDao`, яка зберігає користувачів у базі даних SQLite.

Використайте розроблений компонент у програмі.




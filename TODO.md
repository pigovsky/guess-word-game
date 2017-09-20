# Методичні рекомендації до виконання лабораторних робіт з дисципліни Конструювання ПЗ

## Перше завдання

Створіть обліковий запис на [gitlab](gitlab.com).
Створіть файл `README.md` з правилами гри.

## Друге завдання 

Створіть у будь-якій мові програмування інтерфейс (трейт) `TaskProvider` з методом `get`, що повертає інстанцію `Task`.

Добавте структуру (кейс-клас) `Task` з полями `question` та `answer` стрічкового типу.

Створіть юніт-тест `TestProviderTest` для компонента `TestProvider`. Тест повинен перевіряти чи метод `get` повертає непорожню (not null) інстанцію `Task`, обидва поля якого також непорожні (not null).

Напишіть найпримітивнішу імплементацію `TaskProviderImpl` інтерфейсу `TaskProvider`.

## Третє завдання

Добавте інтерфейс `GameView` з методами `showSorry(message)`, `showCongratulations(message)`, `showCurrentGuess(guess: String)` та `showTask(task: Task)`.

Добавте інтерфейс `GameService` з властивостями `gameView: GameView`, `taskProvider: TaskProvider` та методами: `guessWord(word: String)`, `guessLetter(letter: String)` і `start()`.

Напишіть юніт-тест `GameServiceTest` для компоненту `GameService`, який засобами [Mockito](http://site.mockito.org/) підставляє імітаційні (mocked) імплементації компонентів `gameView: GameView` і `taskProvider: TaskProvider`. Тест повинен перевіряти чи компонент вірно опрацьовує логіку гри при вірно і невірно вгаданому слові(букві). При цьому слід перевіряти особливі випадки: користувач ввів порожню стрічку, користувач вгадав букву, котра у слові зустрічаєтсья двічі і т.д.




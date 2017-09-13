window.onload = function(){

	var words = [
    'виелица',
    'политех',
    'слово',
    'стул',
    'регенерация',
    'клавиатура',
    'строка',
    'монитор',
    'человек',
    'нога',
    'крокодил',
    'фабрика',
    'море',
    'фонтан',
    'казус',
    'провод',
    'аниме',
    'блоха',
    'огурец',
    'процессор',
    'видеокарта',
    'книга',
    'часы',
    'бутылка',
    'пиксель',
    'телефон',
    'фонограмма',
    'экран',
    'щит',
    'клавиша',
    'щека',
    'цыпленок',
    'больной',
    'щенок',
    'часы',
    'рюкзак',
    'строка',
    'номер',
    'диспетчер',
    'мышь',
    'наклейка',
    'шкаф',
    'проектор',
    'кавычки',
    'скоба',
    'имя',
    'скобка'
];


var question = document.getElementById('__question');

var lifeAmount = document.getElementById('lifes');

var input = document.getElementById('ourInput');

var answer = input.innerHTML;

var button = document.getElementById('submitBtn');

var word = words[Math.floor(Math.random() * words.length) ]; //Беремо будь-яке слово з масиву та рахуємо його довжину

var answerArray = []; 

var lifes = word.length + 10;

for (var i = 0; i < word.length; i++){ //Кожен символ в паличку
    answerArray[i] = '_'
}

var remaingLetters = word.length;

question.innerHTML = 'Вгадайте букву! У вас '+ lifes + ' спроб';

var guess = question.innerHTML;

if (remaingLetters > 0 && lifes > 0){

		lifeAmount.innerHTML = answerArray.join(' ');

		button.onclick = function(){

		console.log(1);

		for(var i = 0; i < word.length; i++){

			if (answer === word)
				{
					alert(1);
				}
		
			else{
				alert(2);
			}

		}

			}
}

lifeAmount.innerHTML = answerArray.join(' ');

if(lifes > 0){
    alert('Це слово - ' + word);
} else {
    alert('слово ' + word);
}

};
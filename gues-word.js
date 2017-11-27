
    /*Default settings*/


	/*-----------------Variables-----------------*/

    var i = 0;
    var j = 0;
    var points = 0;
    var question;
    var answer;

    /*------------------!Variables------------------*/

    /*-----------------Methods-----------------*/

	getQuestion = function() {
		 if(i == params.Tasks.length){
             alert('Молодець! Кількість набраних балів: ' + points + '. Спробувати ще раз? ');
             i = 0;
         }
		return params.Tasks[i].question; 
	}

	getAnswer = function() {
		return params.Tasks[i].answer;
	}

	showQuestion = function() {
		q.innerHTML = getQuestion();
	}

	nextStep = function() {
         i++;
         j++;
         q.innerHTML = getQuestion(); 
        }

    setQuestion = function(){
            if(input.value.toLowerCase() === params.Tasks[i].answer.toLowerCase()){
                alert('+');
                console.log(j);
                points += params.Tasks[i].answer.length;
                q.innerHTML = params.Tasks[i+1].question;
                nextStep();
            }
            else{
                alert('Помилка! Правильна відповідь: ' + params.Tasks[i].answer);
                points += 0;
                nextStep();
            }
        }
	/*-----------------!Methods-----------------*/



/*-----------------Actions-----------------*/
showQuestion();
btn.onclick = function(){
   setQuestion();
   input.focus();
   input.value = '';
}


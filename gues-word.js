
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


    /*--------------Authorization--------------*/

    function validate(users, elem1, elem2, elem3, elem4, field1, field2, error_text) {
        for (var i = 0; i < users.length; i++) {
            if(users[i].username === field1.value && users[i].password === field2.value) {
                elem1.classList.remove('visible');
                elem2.classList.remove('visible');
                elem3.classList.remove('visible');
                elem4.classList.add('visible');
            } else { }
        }
    }

    function goBack(element) {
        element.classList.remove('visible');
    }

    /*--------------!Authorization--------------*/



/*-----------------Actions-----------------*/
showQuestion();
btn.onclick = function(){
   setQuestion();
   input.focus();
   input.value = '';
}


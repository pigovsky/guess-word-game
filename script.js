		

        var q = document.getElementById('quest');
        var btn = document.getElementById('btn');
        var input = document.getElementById('inp');

        var i = 0;
        var j = 0;
        var points = 0;
        var question;
        var answer;

        q.innerHTML = taskProvider();

        btn.onclick = function(){
            setQuestion();
            input.focus();
            this.input.value = '';
        }

        nextStep = function(){
            i++;
            j++;
            q.innerHTML = taskProvider(); 
            if(i > taskObj[i].question.length - 1){
                alert('Молодець! Кількість набраних балів: ' + points + '. Спробувати ще раз? ');
                i = 0;
            }
            q.innerHTML = taskObj[i].question;
        }

        setQuestion = function(){
            if(input.value.toLowerCase() === taskObj[i].answer.toLowerCase()){
                alert('+');
                console.log(j);
                points += taskObj[i].answer.length;
                q.innerHTML = taskObj[i+1].question;
                nextStep();
            }
            else{
                alert('Помилка! Правильна відповідь: ' + taskObj[j].answer);
                points += 0;
                nextStep();
            }
        }

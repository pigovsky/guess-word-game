var questions = [
            'Питання 1',
            'Питання 2',
            'Питання 3',
            'Питання 4',
            'Питання 5',
            'Питання 6'
        ]

        var answers = [
            'Відповідь 1',
            'Відповідь 2',
            'Відповідь 3',
            'Відповідь 4',
            'Відповідь 5',
            'Відповідь 6'
        ]

        var q = document.getElementById('quest');
        var btn = document.getElementById('btn');
        var input = document.getElementById('inp');

        var i = 0;
        var j = 0;
        var points = 0;

        q.innerHTML = questions[i];

        btn.onclick = function(){
            setQuestion();
            input.focus();
            input.value = '';
        }

        nextStep = function(){
            i++;
            j++;
            q.innerHTML = questions[i];
            if(i > questions.length - 1){
                alert('Молодець! Кількість набраних балів: ' + points + '. Спробувати ще раз? ');
                i = 0;
            }
            q.innerHTML = questions[i];
        }

        setQuestion = function(){
            if(input.value.toLowerCase() === answers[j].toLowerCase()){
                alert('+');
                console.log(j);
                points += answers[j].length;
                q.innerHTML = questions[i+1];
                nextStep();
            }
            else{
                alert('Помилка! Правильна відповідь: ' + answers[j]);
                points += 0;
                nextStep();
            }
        }
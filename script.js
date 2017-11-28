

	var q = document.getElementById('quest');
    var btn = document.getElementById('btn');
    var input = document.getElementById('inp');
    var showSignIn = document.getElementById('show-sign-in');
	var backBtn = document.querySelector('.back');
	var startWindow = document.querySelector('.start-window');
	var signInForm = document.getElementById('sign-in-form');
	var getUserName = document.querySelector('.username');
	var getPass = document.querySelector('.pass');
	var submit = document.querySelector('.sing-in-btn');
	var gameField = document.querySelector('.game-field');

/*------------------------game params------------------------*/

	params = {
		Tasks: [
			{question: "question1", answer: "answer"},
			{question: "question2", answer: "answer"},
			{question: "question3", answer: "answer"},
			{question: "question4", answer: "answer"},
			{question: "question5", answer: "answer1"}
		],
	}

/*------------------------!game params------------------------*/

/*------------------------forms------------------------*/


	Users = [
		{username: "user1", password: "qwerty"},
		{username: "user2", password: "qwerty"},
		{username: "user3", password: "qwerty"},
		{username: "user4", password: "qwerty"},
		{username: "user5", password: "qwerty"},
		{username: "user6", password: "qwerty"},
	]

/*------------------------!forms------------------------*/


  submit.onclick = function() {
        validate(Users, startWindow, showSignIn, signInForm, gameField, getUserName, getPass, "Error");
    }

  this.backBtn.onclick = function(){
      goBack(signInForm);
  } 

  showSignIn.onclick = function() {
    startWindow.classList.remove('visible');
    signInForm.classList.add('visible');
  }







   
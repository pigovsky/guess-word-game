import data from '../tasks/all.json';

interface TaskData {
	question: string;
	answer: string;
}

class Task implements TaskData {
	question: string;
	answer: string;

	constructor(data: TaskData) {
		this.question = data.question;
		this.answer = data.answer;
	}
}

function isTaskData(arg: any): arg is TaskData {
	return arg && !!arg.question && !!arg.answer;
}

const tasks: Task[] = [];

for (const record of data) {
	if (!isTaskData(record)) { continue; }
	tasks.push(new Task(record));
}
console.log(tasks);

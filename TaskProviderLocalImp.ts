import {TaskProvider} from "./TaskProvider";
import {Task} from "./Task";
import * as data from 'tasks/all.json';


	const word = (<any>data).name;
	console.log(word);

	class TaskProviderLocalImpl implements TaskProvider{

		Get(){

		}
	}


import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { QuestionClass } from './question-class';
import { ToastrService } from 'ngx-toastr';
import { QuizService } from 'src/app/services/quiz.service';
import { ActivatedRoute } from '@angular/router';

@Component({
	selector: 'app-quizzes',
	templateUrl: './quiz.component.html',
	styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {
	isQuestionCardShow: boolean = false;
	totalAnswered: number = 0;
	rightAnswer!: number;
	questionObj = new QuestionClass();
	@ViewChild('submitModal') submitModal!: ModalDirective;
	@ViewChild('addQuestionModal') addQuestionModal! : ModalDirective;
	@ViewChild('answerModal') answerModal! : ModalDirective;
	@ViewChild('questionForm') questionForm: any;
	@ViewChild('questionTest') questionTest : any;

	@Input() inputNumber: number | undefined;

	constructor( private toastr: ToastrService, private quizService: QuizService, private route: ActivatedRoute) { }

	allQuestions: any = [];

	id = this.route.snapshot.paramMap.get('id');

	importedQuestions: any = this.quizService.getQuiz(Number(this.id))
	.subscribe(
        (response) => {                           //next() callback
          console.log('response received', response)
		  this.allQuestions = response.questions;
        },
        (error) => {                              //error() callback
          console.error('Request failed with error')
        },
        () => {                                   //complete() callback
          console.error('Request completed')      //This is actually not needed 
        })

	/**Method call on submit the test */
	submitTest() {
		this.rightAnswer = 0;
		this.totalAnswered = 0;
		for (let i = 0; i < this.allQuestions.length; i++) {
			if ("selected" in this.allQuestions[i] && (this.allQuestions[i]["selected"] != null)) {
				this.totalAnswered++;
				if (this.allQuestions[i]["selected"] == this.allQuestions[i]["answer"]) {
					this.rightAnswer++;
				}
			}

		}
		this.submitModal.show();

	}

	startQuiz() {
		console.log(this.allQuestions);
		console.log("!!!!!!!!!!!!!!!!!!!!!!!!!");
		for (let i = 0; i < this.allQuestions.length; i++) {
			if ("selected" in this.allQuestions[i]) {
				delete this.allQuestions[i]["selected"];
			}

		}
		this.questionTest.reset();
		this.isQuestionCardShow = true;

	}
	HomePage() {
		this.isQuestionCardShow = false;
	}
	addQuestion(){
		this.addQuestionModal.show();
	}
	submitAddQuestion(){
		let quesTemp = JSON.parse(JSON.stringify(this.questionObj));
		quesTemp["id"] = this.allQuestions.length+1;
		this.allQuestions.push(quesTemp);
		this.questionForm.reset();
		this.toastr.success("Question Added Successfully!!");
		this.addQuestionModal.hide();

	}
	checkAnswers(){
		this.submitModal.hide();
		this.answerModal.show();
	}

	ngOnInit() {

	}

}

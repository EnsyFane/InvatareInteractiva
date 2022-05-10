import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-popup',
  templateUrl: './popup.component.html',
  styleUrls: ['./popup.component.scss']
})
export class PopupComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public data: any, private dialogRef: MatDialogRef<PopupComponent>) { }

  public title: string = ""; 
  public text: string = ""; 

  ngOnInit(): void {
    this.title = this.data.title;
    this.text = this.data.text;
  }

  close(): void {
    this.dialogRef.close();
  }

}

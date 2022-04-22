import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/_models/member';
import { MemberService } from 'src/app/_services/member.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

public members: Member[];

  constructor(private memberService: MemberService) { }

loadMembers(){
  debugger
  this.memberService.getMembers().subscribe(memberList => {
    this.members = memberList;
  })
}

  ngOnInit(): void {
    this.loadMembers();
  }

}

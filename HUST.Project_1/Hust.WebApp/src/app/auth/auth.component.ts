import { CommonService } from './../common.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent implements OnInit {

  constructor(private commonSer:CommonService) { }

  ngOnInit() {
    const $formLogin = $('#login-form');
    const $divForms = $('#div-forms');
    const $modalAnimateTime = 300;
    const $msgAnimateTime = 150;
    const $msgShowTime = 2000;

    $('form').submit(function () {
      const $lg_username = $('#login_username').val();
      const $lg_password = $('#login_password').val();
      if ($lg_username === 'ERROR') {
        msgChange($('#div-login-msg'), $('#icon-login-msg'), $('#text-login-msg'), 'error', 'glyphicon-remove', 'Send error');
      } else {
        msgChange($('#div-login-msg'), $('#icon-login-msg'), $('#text-login-msg'), 'success', 'glyphicon-ok', 'Send OK');
      }
      return false;
    });
    function msgFade($msgId, $msgText) {
      $msgId.fadeOut($msgAnimateTime, function () {
        $(this).text($msgText).fadeIn($msgAnimateTime);
      });
    }

    function msgChange($divTag, $iconTag, $textTag, $divClass, $iconClass, $msgText) {
      const $msgOld = $divTag.text();
      msgFade($textTag, $msgText);
      $divTag.addClass($divClass);
      $iconTag.removeClass('glyphicon-chevron-right');
      $iconTag.addClass($iconClass + ' ' + $divClass);
      setTimeout(function () {
        msgFade($textTag, $msgOld);
        $divTag.removeClass($divClass);
        $iconTag.addClass('glyphicon-chevron-right');
        $iconTag.removeClass($iconClass + ' ' + $divClass);
      }, $msgShowTime);
    }
  }
  
  goState(state): void {
    this.commonSer.goState(state);
  }
}

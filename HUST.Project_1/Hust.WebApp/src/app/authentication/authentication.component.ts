import { Routes, RouterModule } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';
import{Router} from '@angular/router'


@Component({
  selector: 'app-authentication',
  templateUrl: './authentication.component.html',
  styleUrls: ['./authentication.component.css']
})
export class AuthenticationComponent implements OnInit {

  constructor(private router: Router) { }


  ngOnInit() {
    $(function () {
      const $formLogin = $('#login-form');
      const $formLost = $('#lost-form');
      const $formRegister = $('#register-form');
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

      // $('#login_register_btn').click(function () { modalAnimate($formLogin, $formRegister); });
      // $('#register_login_btn').click(function () { modalAnimate($formRegister, $formLogin); });
      // $('#login_lost_btn').click(function () { modalAnimate($formLogin, $formLost); });
      // $('#lost_login_btn').click(function () { modalAnimate($formLost, $formLogin); });
      // $('#lost_register_btn').click(function () { modalAnimate($formLost, $formRegister); });
      // $('#register_lost_btn').click(function () { modalAnimate($formRegister, $formLost); });

      // function modalAnimate($oldForm, $newForm) {
      //   const $oldH = $oldForm.height();
      //   const $newH = $newForm.height();
      //   $divForms.css('height', $oldH);
      //   $oldForm.fadeToggle($modalAnimateTime, function () {
      //     $divForms.animate({ height: $newH }, $modalAnimateTime, function () {
      //       $newForm.fadeToggle($modalAnimateTime);
      //     });
      //   });
      // }

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
    });
  }

goLogin():void{
  this.router.navigate(['/dashboard']);
}

}

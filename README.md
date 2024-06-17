# Chapter 3-3 Unity 게임개발 심화 개인과제
# 2D 클리커 게임

[코드컨벤션]

      1. namespace, class, struct : PascalCase
      2. variable: camelCase
      3. Function : PascalCase / 함수 내부: camelCase
      4. Public : PascalCase / Non Public : _camelCase

[깃허브컨벤션]

      <Branch 내부작업>
      Fix : 버그, 오타 수정
      Complex : 여러가지 일 수행
      Feature : 새로운 기능 추가
      Update : 기존 기능을 업데이트 했을 때
      
      Rename : 파일 혹은 폴더명 수정하거나 옮기는 경우
      Remove : 파일을 삭제하는 작업만 수행하는 경우
      Chore : 기타 변경사항
      
      Refactor : 더 나은 코드로 변경
      Move : 코드의 이동이 있는 경우

[게임 설명]

Tap Titans 모작 느낌으로 Mouse 왼쪽 클릭, TouchScreen Tab 할 시 애니메이션이 실행되면서 공격.
Monster Hp가 0이 되면 Gold가 늘어나면서 1초 뒤에 Monster Setting일 거쳐서 다시 SetActive(True)가 됨.
무한 반복

 [구현한 기능]
 
 1. 클릭 이벤트 처리
 2. 자동 클릭 기능
 3. 점수 시스템
 4. 아이템 및 업그레이드 시스템
 5. 게임 내 통화 시스템
 6. 애니메이션

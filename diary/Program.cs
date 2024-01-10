﻿/*
 ## 프로젝트 요구사항

프로젝트명은 자유롭게 작성합니다.

간단한 일기장 프로그램을 작성해 봅시다. 일기장 파일은 .txt 확장자로 하고

매 일기장은 날짜 당 하나씩의 파일로, 날짜를 파일명으로 생성하도록 해주세요.

프로그램에서 내용 추가 모드에선 제목과 내용만 입력할 수 있게 하면됩니다. 등록 시 에는 아래

### 시간 : 자동 대입

### 일기 제목

내용

의 서식으로 기존 파일의 뒷 부분에 이어 붙이게 해주세요.

그리고 읽기 모드에선 파일 열기 대화상자로 파일을 열면

(1/n)

### 시간 : 자동 대입

### 일기 제목

내용

이런 식으로 하나씩 표시되고, 좌우 방향키로 각각의 항목을 이동해서 표시하게끔

esc누르면 다시 모드선택화면으로 나오게 해주세요

깃허브 최상단에는

[readme.md]파일을 만들어 프로그램 사용법을 기술해 주시시 바랍니다
*/

using diary;

class Program {
    static void Main(String[] args)
    {
        Service srv = new();
    }
}
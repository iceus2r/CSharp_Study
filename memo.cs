라인 1개 == 600x100px

일반노트
300x75
양쪽 35씩 투명여백
실제크기는 230x75
Sprite 크기 3x0.75

75px 원
+
가로 38px 위치 세로선 길이 75px
+
가로 오른쪽 끝 세로선 길이 21px

7.4075
4.4445
1.4815

-4
0.5

0.25

Dialog 56px 한줄에 23자(한글) 가능
여백 가로53 세로40

/*Client
-Bad시 노트 비활성화

-(문서참고)일반노트 오브젝트 재활용
NotePool을 Queue로 구현?
처음에 라인별로 20개 만들고 Queue에 넣기, 모두 비활성화
라인별 첫 20개 생성
하나 쓸 때마다 비활성화
바로 다음 위치로 노트 이동생성
NoteDataInspector로 인스펙터에 NoteData 출력

-(생각좀)음악 Addressable 개별 그룹으로 변경

-노트 소리 추가
EventInstance로 재생

-Resources.Load Addressable로 전환하기
*/

/*PatternEditor
Undo 기능은 Stack으로 구현
특정 마디 복사 기능
겹치는 노트 알림
Long노트 길이 0칸 되지 않게 하기
음악 끝나면 스크롤 멈추기
확대축소기능-확대&축소 후 현재 마디 기준으로 위치 정렬
메시지 2줄 이상
*/

/*텍스쳐 압축 방법
Max Size - 텍스쳐 원본 사이즈보다 한 단계 작은 사이즈로 압축 추천
Format - RGB(A) Compressed ASTC 4x4 ~ 8x8 block 추천
색상이 많고 그라데이션이 부드러울수록 4x4
아니라면 6x6

PSD파일에 Alpha값 적용 시
Alpha Is Transparency
Remove Matte (PSD)
두 항목 체크
*/

/*작곡
바이올린 피치카토
스네어드럼
Estate Grand LE for sforzando
*/

노트 한개당 6길이

【】

Static Manager
Manager
Script
Prefab
Object
Value(카테고리)
Value

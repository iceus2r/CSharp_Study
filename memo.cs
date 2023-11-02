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
인터넷 연결 확인
SceneLoader CanvasGroup Alpha값 조절로 변경
Dialog 스킵할때 말소리 한번에 나오는 것 수정

-Addressable에 폰트 추가
UITitle TMP_FontAsset 불러오는거까지 완료

-일반노트 오브젝트 재활용
Initialize시 모든 노트의 NoteDropper 기준 스폰 위치를 기록
한번에 출력 가능한 최대 갯수를 정해서
노트 낙하 완료 후에도 오브젝트의 위치를 변경하여
노트 오브젝트의 재사용이 가능하도록 개선
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

8u371

【】

LithosPro 사용글자
0123456789.+-JUDGEMS

NanumSquareNeo 사용글자
0123456789KMGB().?!필수데이터다운로드가필요합니다약지금다운로드하시겠습니까취소를누르면게임이종료됩니다중완료 

영어     32-126     (95자)
상용한글 44032-55203(11172자)
한글자모 12593-12643(51자)
특수문자 8200-9900  (1701자)


tempFont = Addressables.LoadAssetAsync<TMP_FontAsset>(TMP_Settings.defaultFontAssetPath + new string(m_htmlTag, m_xmlAttribute[0].valueStartIndex, m_xmlAttribute[0].valueLength)).WaitForCompletion();


	var fontHandle = Addressables.LoadResourceLocationsAsync("Font", typeof(ScriptableObject));
        fontHandle.Completed += fontLocations =>
        {
            foreach (IResourceLocation location in fontLocations.Result)
            {
                string locationPrimaryKey = location.PrimaryKey;
                Addressables.LoadAssetAsync<TMP_FontAsset>(locationPrimaryKey).Completed +=
                    font =>
                    {
                        MaterialReferenceManager.AddFontAsset(font.Result);
                    };
            }
        };
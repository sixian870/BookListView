# 圖書管理程式

利用 Windows Form 搭配物件導向架構設計的圖書整合管理應用程式，提供讀者直觀的書籍檢視、即時關鍵字搜尋與借還書功能，並建立管理員動態上架專區，讓使用方式更彈性。


## 核心功能

### 1. 多視角書籍檢視切換：

* 提供「大圖示」、「詳細資料」、「小圖示」、「清單」以及「大圖示加詳細資料」五種不同的 ListView 檢視模式，讓使用者依個人喜好自由調整目錄排版。
  
### 2. 即時關鍵字搜尋：

* 使用者無需點擊搜尋鈕，只要輸入字元，系統便會即時針對書名、作者及書籍類別進行不分大小寫的比對，快速篩選目標書籍。

### 3. 完善的借還書機制：

* **重複借閱阻擋**：借書時系統會自動掃描借閱清單，若偵測到重複書籍，將跳出警告視窗。
  
* **借閱時間紀錄**：確認借閱後，系統會利用 DateTime 自動擷取當前電腦系統時間，以 `yyyy/MM/dd HH:mm` 格式產生借閱紀錄。

* **雙擊借還書**：使用者可透過簡單操作實現目的。

### 4. 管理員動態新書上架：

* 管理員可透過填寫「書名、作者、類別」並「選取書封」上架書籍，而非侷限於系統預設之書籍。

### 5. 無滑鼠操作：

* 全程支援 `tab 鍵` 跳轉與 `空白鍵` 選取。


## 使用說明

以下為預設視窗介面：

<img width="700" alt="螢幕擷取畫面 2026-05-18 022626" src="https://github.com/user-attachments/assets/5a2712e5-3b7c-4f3d-9fd3-9eb12e2fca23" />



1.  **切換檢視**：
   
    * 啟動程式後，左側會自動載入系統內建的十三本精選書籍。
  
    * 可以透過**滑鼠點擊**或**上下鍵選取**右側上方的「檢視方式」下拉選單，任意切換五種瀏覽模式，分別為「大圖示、詳細資料、小圖示、清單、大圖示加詳細資料」，以下為五種瀏覽模式介面展示圖：
  
      <img width="450" alt="螢幕擷取畫面 2026-05-18 022626" src="https://github.com/user-attachments/assets/b65fa03f-90df-4030-bd02-513ea35b654d" /> <img width="450" alt="螢幕擷取畫面 2026-05-18 022940" src="https://github.com/user-attachments/assets/7bbb3980-e245-4480-8034-a137d3072a23" /> <img width="450" alt="螢幕擷取畫面 2026-05-18 023127" src="https://github.com/user-attachments/assets/cda378ae-6880-4ea7-a181-2e776b86c29f" /> <img width="450" alt="螢幕擷取畫面 2026-05-18 023143" src="https://github.com/user-attachments/assets/fb6e1117-5c1a-45b4-b23e-1b0edf681e42" /> <img width="450" alt="螢幕擷取畫面 2026-05-18 023228" src="https://github.com/user-attachments/assets/fad24a1e-8975-46de-bdcd-993211a7ebf3" />

2.  **關鍵字搜尋**：
   
    * 在左上角的搜尋方塊內輸入欲查找書籍的書名、作者、類型三者其一的關鍵字即可，底下的書籍列表會根據你的輸入要求即時更動。
    * 清空搜尋方塊即可回復完整書籍清單。
    * 以下範例圖為欲查找類型包含關鍵字小說之書籍的結果：
  
      <img width="450" alt="螢幕擷取畫面 2026-05-18 023937" src="https://github.com/user-attachments/assets/f5f82468-c687-41aa-8f1b-f858f49d81ba" />


3.  **借閱書籍**：
   
    * 用**滑鼠連按兩下**或用 `上下鍵` 選取+ `Enter鍵` 確認，選擇左側清單中的任一書籍，就會跳出「借閱確認」之提示。
  
      <img width="400" alt="螢幕擷取畫面 2026-05-18 024621" src="https://github.com/user-attachments/assets/2588777b-f205-4049-a543-f2696bacce36" />

    * 用**滑鼠或空白鍵**點選「是」後，該書名就會連同當前的借書時間一起登記到左側的「借書清單」中。
   
      <img width="400" alt="螢幕擷取畫面 2026-05-18 024636" src="https://github.com/user-attachments/assets/1343dd6b-f762-4ce2-8644-c3d036dcfbf0" />

    * 若重複借閱同一本書，系統會彈出警告，無法重複塞入清單，用**滑鼠或空白鍵**點擊關閉視窗即可繼續使用。

      <img width="400" alt="螢幕擷取畫面 2026-05-18 024702" src="https://github.com/user-attachments/assets/df4c8d04-e0a0-40c5-aced-2503554b48b5" />


4.  **歸還書籍**：

    * 當需要還書時，直接對著右下角借書清單中的項目用**滑鼠點擊兩下**或用**上下鍵選取+Enter確定**，就會跳出如「確定要歸還《三國演義》嗎？」的提示視窗，點擊確定即可完成歸還。
  
      <img width="400" alt="螢幕擷取畫面 2026-05-18 025355" src="https://github.com/user-attachments/assets/61ce26bc-f34b-4754-bcbc-3cc1d8a4125f" />


5.  **管理員上架新書**：
      
    * 在下方的「管理員功能」中輸入新書的書名、作者、類別。

      <img width="400" alt="螢幕擷取畫面 2026-05-18 025944" src="https://github.com/user-attachments/assets/72e5768d-ddbb-492d-9973-ebd25a9a90d6" />

    * 用**滑鼠或空白鍵**點擊 `選擇書封` 按鈕選取電腦中的書封影像（支援 .jpg, .png, .jpeg 等格式）。
  
      <img width="400" alt="螢幕擷取畫面 2026-05-18 030020" src="https://github.com/user-attachments/assets/64cc271d-05bc-43ed-a7a2-95059ba4d95e" />

    * 用**滑鼠或空白鍵**點擊 `上架`，確認成功後，新書便會與圖片一起加入左側的書單。

      <img width="400" alt="螢幕擷取畫面 2026-05-18 030043" src="https://github.com/user-attachments/assets/9639ac46-0320-43ca-9fc5-c610d5e160af" /> <img width="400" alt="螢幕擷取畫面 2026-05-18 030119" src="https://github.com/user-attachments/assets/769ae460-2a4d-45a6-950c-7d1e2aad77b0" />


## 參考資料

[書封圖片參考](https://www.kobo.com/tw/zh)


## 開發環境

* **開發語言**：C# (.NET Framework)
* **開發工具**：Visual Studio 2022

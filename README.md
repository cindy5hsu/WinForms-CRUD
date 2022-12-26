# 家教後台管理系統
幫助需要任何尋找家教的人們進行媒合的後臺管理系統，裏面詳細的記錄了科目分類以及時數價格，信息公開透明

## 功能介紹
1. 有新建，增加，刪除，修改（CRUD）
2. 使用到擴充方法，叫用 ISPan.Utility
3. 加入了 ErrorPrvider 在沒填入個人資訊時就會跳出警示提醒未填密碼或者賬號
4. 增加老師個人咨詢時設計了可以上傳個人圖片裏面有5種類型的圖片可以做讀取。

# 維護商品記錄功能簡述
在新增及編輯功能裡,都先將表單資訊建立成ViewModel,再進行欄位驗證.
在EditForm一開始,先載入一筆記錄, 轉換成ViewModel,再繫結到各控制項裡

# 困難之處
在加入圖片時花了一段時間研究如何把圖片加入到資料庫，
另外有用到擴充方法，所以有時沒有參考到擴充方法所以也花了一段時間Debugger

![image](https://github.com/cindy5hsu/WinForms-CRUD/blob/master/Project_Store/Resources/%E8%9E%A2%E5%B9%95%E6%93%B7%E5%8F%96%E7%95%AB%E9%9D%A2%20(42).png?raw=true)

# MyHelloWorldAPI

這是一個GET API，會回傳一個Hello World字串

## 如何使用

### 環境要求
- [.NET Core SDK](https://dotnet.microsoft.com/zh-cn/download) (.NET 8.0)

### 安裝專案
1. Clone專案至你的電腦：
   ```
   Git Bash
   git clone https://github.com/sj2321672/MyHelloWorldAPI.git   
   ```
2. 在專案資料夾底下開啟Cmd輸入指令建置專案
   ```
   Cmd
   dotnet run 
   ```
3. 建置成功後，輸入網址 http://localhost:4000/Swagger 即可測試API

### API
API將運行在http://localhost:4000/HelloWorld
- **GET** `/HelloWorld`
  返回"Hello World"字串 

### 使用ngrok讓外網可以使用API
- [ngrok](https://ngrok.com/)
  完成註冊後，
1. 啟動ngrok，並輸入你的Authtoken：
   ```
   ngrok
   ngrok config add-authtoken <Your-Authtoken>
   ```

2. 開放外網連線至你的localhost
   ```
   ngrok
   ngrok http 4000
   ```
    這裡的4000為API專案預設的端口，可以在專案的launchSettings.json修改

3. ngrok將提供一個公開的URL，類似於" https://8f97-2001-b011-e006-9f59-c472-e1b8-a83c-6bbc.ngrok-free.app "

4. 在URL後面加上/helloWorld即可使用此API，"https://8f97-2001-b011-e006-9f59-c472-e1b8-a83c-6bbc.ngrok-free.app/helloWorld"

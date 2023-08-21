@echo off
copy "SCDream4.otf" "%WINDIR%\Fonts"
reg add "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts" /v "에스코어 드림 4 Regular (TrueType)" /t REG_SZ /d SCDream4.otf /f
timeout /t 2 /nobreak >nul
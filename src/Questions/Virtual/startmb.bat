@echo off
call "C:\Program Files\nodejs\nodevars.bat"
mb --configfile templates/server.ejs --allowInjection
pause 
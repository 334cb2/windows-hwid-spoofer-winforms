@echo off
echo Pushing to GitHub...
git add .
git commit -m "Update repository"
git push origin master
if %errorlevel% equ 0 (
    echo.
    echo ✓ Successfully pushed!
) else (
    echo.
    echo ✗ Push failed!
)
pause


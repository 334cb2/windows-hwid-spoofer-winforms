@echo off
echo ========================================
echo   Pushing to GitHub Repository
echo ========================================
echo.

REM Check if git is initialized
if not exist .git (
    echo Error: Not a git repository!
    echo Please run: git init
    pause
    exit /b 1
)

REM Add all changes
echo [1/3] Adding all changes...
git add .
if %errorlevel% neq 0 (
    echo Error: Failed to add files!
    pause
    exit /b 1
)
echo ✓ Files staged successfully
echo.

REM Commit changes
echo [2/3] Committing changes...
set /p commit_msg="Enter commit message (or press Enter for default): "
if "%commit_msg%"=="" set commit_msg=Update repository
git commit -m "%commit_msg%"
if %errorlevel% neq 0 (
    echo Error: Failed to commit!
    pause
    exit /b 1
)
echo ✓ Changes committed successfully
echo.

REM Push to GitHub
echo [3/3] Pushing to GitHub...
git push origin master
if %errorlevel% neq 0 (
    echo.
    echo Error: Failed to push!
    echo Make sure you have:
    echo   - Internet connection
    echo   - Git credentials configured
    echo   - Push permissions to the repository
    pause
    exit /b 1
)
echo.
echo ========================================
echo   ✓ Successfully pushed to GitHub!
echo ========================================
echo.
pause


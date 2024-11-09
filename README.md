
# Project Setup Guide

This repository contains two main projects: **Back-End** and **Front-End**. Follow the instructions below to set up and run each part.

## Back-End Setup

1. Navigate to the `back-end` folder.
2. Install the necessary packages by running:
   ```bash
   dotnet restore
   ```
3. To set up the SQLite database, run migrations with:
   ```bash
   dotnet ef database update
   ```
4. Start the project using Visual Studio Code:
   - Press **F5** to launch the project.

5. Access the Swagger UI to explore and test the API:
   - Visit: [http://localhost:5042/swagger/index.html](http://localhost:5042/swagger/index.html) or [https://localhost:7048/swagger/index.html](https://localhost:7048/swagger/index.html)
   
6. **Authentication**: 
   - Use the **Login** API call with `useCookies` and `useSessionCookies` set to `true` (selectable in the dropdowns) to authenticate and test protected routes.

## Front-End Setup

1. Go to the `front-end` folder.
2. Install the required packages:
   ```bash
   npm install
   ```
3. Start the front-end application:
   ```bash
   npm start
   ```
4. Open a browser and go to [http://localhost:4200/](http://localhost:4200/) to access the front-end application.

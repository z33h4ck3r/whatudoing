# WUD: Social Productivity Platform (C#)

WUD (What U Doing) is a console-based social productivity platform where friends can track, share, and motivate each other through daily tasks. This project demonstrates object-oriented programming, user input handling, and foundational CRUD operations, with a social twist.

## Features

- Add new tasks with a description
- View all current tasks with completion status
- Mark any task as completed
- Delete specific tasks
- Share tasks with friends (social feed)
- Add/remove friends
- Basic input validation for smooth user experience

## Getting Started

1. **Clone** this repository to your machine.
2. Open the project in [Visual Studio](https://visualstudio.microsoft.com/) or another C# IDE.
3. Build and run the application.

## Usage

- Navigate the menu to manage tasks and social interactions:
  - Add multiple tasks quickly.
  - View your tasks and those shared by friends.
  - Mark tasks as completed and encourage friends.
  - Delete tasks you no longer want to track.
  - Manage your friends list.

### Example

```
Task Manager
1. Add a task
2. Show task list
3. Mark task as completed
4. Delete a task
5. Manage Friends
6. Exit

> 1
Enter the new task:
Clean my desk

Is that the only task? (Yes/No)
no

Enter the new task:
Finish C# project

Is that the only task? (Yes/No)
yes

Task added!
```

## Project Structure

- `Task` class — represents each todo item (`Description`, `IsDone`, `SharedWithFriends`).
- `User` class — handles user data, friends list, and shared tasks.
- `Program` class — contains main functionality:
    - `AddTask()`
    - `ShowTasks()`
    - `MarkTaskAsDone()`
    - `DeleteTask()`
    - `ManageFriends()`

## Roadmap & Future Improvements

- **Persistence:** Save and load tasks/users to a database (SQLite/MySQL/PostgreSQL).
- **Feed & Social Features:** Display friends' shared tasks, enable likes/comments, and encourage interaction.
- **Gamification:** Implement streaks, badges, and group challenges.
- **Advanced Filters & Analytics:** Track personal and friend productivity trends.
- **User Interface Upgrade:** Move to a web app (ASP.NET Core/Blazor) or mobile-friendly interface.

## Motivation

WUD combines productivity and social interaction, making task management fun and collaborative. This project is a portfolio-ready demonstration of C# fundamentals, social feature integration, and app evolution from console to full platform.

---

*Made with 💻 in C# by Zolani Mzimela*


# MobileStaffApp
Preview demo of the current state of the application
![Alt Text](https://github.com/mrteeson94/MobileStaffApp/blob/master/mobileapp_demo.gif)

## Table Content
* [Application Summary](#Application-Summary)

* [Technology & Language Used](#Technology-&-Language-Used)

* [Functionality](#Functionality)

## Application Progression Summary

The mobile application allow stakeholders of a company in this context to 
view the company's employee's details such as name, contact number and department. 
Users with admin access are able to add new employee and edit existing employee details. 

The overall goal of this project is to be a general contact staff mobile-application to allow users to contact certain staff directly,
which can avoid the experience of long wait periods on MS teams/stack.

This project provided an oppurtunity for me to explore a new design pattern (MVVM) for object-oriented programming
(OOP) that helps seperate the environment of the application UI (XAML) from the business logic code (C#) and also
integrating database (SQLite) reinforeced my knoweldge on database manipulation (CRUD).

## Technology & Language Used
* Framework: Xamarin Forms 5.0.0.2515
* Languages: C# and XAML 
* IDE: Visual Studio 2022 (Community version)
* Components (via Nuget Packages): Sqlite-net-pcl 1.8.116

## Functionality
* Able to export and load up csv details
* Display all staff profiles on the main page
* Dedicated staff profile page that contains each staff general details 
* Currently runs on android os devices and supports mobile and tablet devices
* Utilises SQLite to allow creation, update and deletion of employees

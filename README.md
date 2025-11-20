# Offence Decision Support System
Automated Offence Decision Support System (AODSS)
Final Year Project – Standalone Desktop Application
📌 Project Overview

The Automated Offence Decision Support System (AODSS) is a C# desktop application designed to automate the process of recording offences, analyzing predefined rules, and generating recommended penalties for better administrative decision-making.

It was built as a standalone Windows application, suitable for schools, organizations, transport agencies, and other institutions that handle repetitive offence records.

🎯 Project Objectives

Automate the process of documenting offences.

Provide a Decision Support System (DSS) that suggests penalties based on encoded rules.

Maintain accurate offence records and offender history.

Ensure consistent and unbiased judgement by using a matching algorithm to match student offences to the appropriate punishment based on predefined rules.

Reduce human error in manual decision-making.

🛠️ Technologies Used
Programming Language

C# (.NET Framework)
(WinForms or WPF — I can update this if you specify which one)

Database

SQL Server (LocalDB / SQL Server Express)

ADO.NET for data access

Tools

Visual Studio

SQL Server Management Studio (SSMS)

Git & GitHub

📂 Major Features
1. Authentication Module

Secure admin login

User roles (Optional)

2. Offence Management

Add new offences

Edit/update offences

Categorize offences

Soft-delete/archive options

3. Decision Support Engine

A rule-based engine that automatically recommends penalties using:

Severity rating

Offence category

Repeat offender count

Institution’s policy rules

4. Penalty Assignment

Displays recommended action

Allows admin to approve or override

Stores justification for overrides

5. Offender History Tracking

Views all offences committed by an individual

Monitors frequency + recurrence

6. Reporting System

Printable offence reports

Filter by date, category, offender, or penalty

Export to PDF/Excel (optional depending on your build)

7. Audit Trail (Optional)

Tracks major actions performed in the system

Helps maintain accountability

⚙️ System Architecture
1. Presentation Layer

C# WinForms/WPF UI

2. Business Logic Layer

Rule engine

Validation

Decision-making algorithms

3. Data Layer

SQL Server database

Tables for offences, users, penalties, logs, etc.


📘 Research Contribution

This project demonstrates how decision-support systems can:

Enhance disciplinary transparency

Ensure fairness and consistency

Speed up administrative processes

Reduce bias and manual inconsistencies

It also shows the practical integration of rule-based AI logic in everyday institutional workflows.

📄 License

Academic use only.
For customization or commercial use, contact the author.

👤 Author

Michael Abraham
Department of Computer Science
Clifford University
Final Year Project

# GROUP1_PIER15_SDG11_COMMUNITY-ISSUE-REPORTING-SYSTEM

# Community Issue Reporting System

A digital platform designed to help residents easily report local barangay problems and enable community management teams to track, organize, and resolve issues effectively. This project aligns with **UN Sustainable Development Goal (SDG) 11: Sustainable Cities and Communities**, fostering cleaner, safer, and more collaborative urban environments.

---

## 📌 Project Overview
The **Community Issue Reporting System** streamlines local reporting processes by replacing unorganized communication channels with a centralized tracking system. 
* **For Citizens:** Provides an accessible method to report community issues (e.g., illegal garbage disposal, flooding, road damage) with details, category, location, and supporting photo evidence
* **For Barangay Staff/Admins:** Offers a tracking system to assign priority levels, update issue statuses, handle notifications, and view basic analytics via an administrative dashboard.

### 🌍 Connection to UN SDG 11
* **Target 11.3:** Promotes participatory, integrated, and sustainable community planning by encouraging resident participation in reporting local issues.
* **Target 11.6:** Reduces environmental impacts through efficient reporting and tracking of environmental concerns like improper waste disposal and infrastructure management.

---

## 🛠️ System Features

### 🔹 Functional Requirements
* **FR-1: User Registration & Authentication** – Secure citizen sign-up/login; only authenticated users can submit reports.
* **FR-2 & FR-3: Issue Reporting & Categorization** – Submit reports across predefined categories (Garbage Disposal, Road Damage, Flooding, Street Light Malfunction, Noise Complaints) including description, location, and optional photo attachment.
* **FR-4 & FR-5: Report Management** – Citizens can edit/delete their reports while still pending. [cite_start]Barangay staff can manage all incoming tickets, update statuses (`Pending`, `In Progress`, `Resolved`), and assign priority levels (`Low`, `Medium`, `High`, `Urgent`).
* **FR-6: Assignment System** – Administrators can assign active issues to specific barangay personnel or external teams for direct resolution.
* **FR-7: Transparency History Board** – Tracks changes, logs actions, and documents updates to support accountability across the platform.
* **FR-8 & FR-10: Dashboard, Analytics & Search** – Administrative view displaying total, pending, and resolved case counts along with analytics on frequently reported issues.Includes search, filtering, and automated sorting.
* **FR-9: Notification System** – Real-time updates alerting residents to changes in status or priority for their reported items.

### 🔹 Quality Attributes (Non-Functional Requirements)
* **Usability (NFR-1):** User-friendly interface requiring minimal technical knowledge to navigate.
* **Performance (NFR-2):** Quick page loading speeds and rapid data transactions under standard usage.
* **Reliability (NFR-3):** Solid data integrity mechanisms ensuring submissions are securely stored without loss.
* **Security (NFR-4):** Strict authorization protocols; administrative modules are restricted exclusively to staff personnel.
* **Scalability & Maintainability (NFR-5, NFR-6):** Designed to handle an expanding database of community members and accommodates future module integrations.

---

## 🗄️ Database Architecture
The backend architecture is structured around the following core relational modules:

* **USERS:** Manages user identities and security classifications (`CITIZEN`, `STAFF`, `ADMIN`).
* **CATEGORIES:** Stores unique problem domains to route entries correctly.
* **REPORTS:** Tracks central problem reports containing location text, priority status, and timestamp logs.
* **REPORT_PHOTOS:** Handles attachments linked to the parent report record.
* **ASSIGNMENTS:** Maps distinct reports to individual workers responsible for fieldwork.
* **REPORT_HISTORY:** Audit log capturing `action_type` and chronological activity notes.
* **NOTIFICATIONS:** Manages user alert states and delivery conditions.

---

## 🚀 Getting Started

### 📋 Prerequisites
Before running the application, make sure you have the following installed and configured:

* **.NET Framework / .NET SDK** (matching your project version, e.g., .NET Framework 4.8 or .NET 6/8)
* **Visual Studio** (2019 or newer recommended with the *.NET Desktop Development* workload installed)
* **Microsoft SQL Server** (Express, Developer, or Enterprise edition)
* **SQL Server Management Studio (SSMS)** (highly recommended for managing the database)
* Your Backend Environment (e.g., Node.js / Python / PHP)
* Database management framework (e.g., MySQL / PostgreSQL)

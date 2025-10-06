# 🛍️ E-Commerce Website with MongoDB (Coza Store)

This project is a **modern e-commerce web application** built using **ASP.NET Core MVC 6.0** and **MongoDB (NoSQL)**.  
Users can browse products, filter them by categories, follow promotions through the slider, and subscribe via email to receive discount coupons.  
All product, category, and slider content can be easily managed through the admin panel.  

This project was developed under **M&Y Yazılım Eğitim Akademi Danışmanlık(M&Y Software Education Academy Consulting)**, mentored by **Murat Yucedag**.

---

## 💡 About the Project

Through this project, I:

- Learned **NoSQL-based data management** using MongoDB.  
- Gained hands-on experience in **developing a real e-commerce website from scratch**.  
- Practically applied the process of **building a single-layer project** with ASP.NET Core MVC architecture.  

Thanks to MongoDB’s flexible structure, data such as products, categories, and sliders are managed with high performance.  
For data operations, **MongoDB.Driver** and **MongoDB.Bson** libraries were used.  
In addition, all product, category, and slider contents can be easily managed through the admin panel.

---

## 🧩 Application Structure

The system consists of two main parts:

- 👤 **Admin Panel:** A management panel where products, categories, stock control, and orders can be handled.  
- 📱 **Storefront Panel:** A responsive, user-friendly interface where users can filter products by categories and shop easily.

Other features included in the project:

- Multiple images per product  
- Category-based filtering  
- User reviews  
- Dynamic content management  
- Promotion tracking via slider  
- Responsive design

---

### 🏠 Home Page

Users can:

- View products  
- Follow promotions through the slider  
- Filter products by categories  

**Screenshot suggestion:** The home page showing slider and categories.

---

## 🧩 Learned and Applied Skills

- NoSQL data management with MongoDB – Flexible and high-performance data storage and querying  
- Single-layer project development in ASP.NET Core MVC – Managing Controllers, Models, and Views in one project  
- Automated email sending with MailKit – Sending subscription and discount coupon emails to users  
- Responsive web design – Optimizing user experience across all devices  
- Asynchronous data operations (**Async/Await**) – Efficient and uninterrupted data handling  
- Modern web design with Bootstrap 5 – Creating a contemporary and responsive UI  

---

## 🗄️ MongoDB and Data Operations

Instead of a relational database, **MongoDB** was used.  
Data is stored in **BSON (Binary JSON)** format, providing flexibility.  
Data models are defined as C# classes (Entities), and **DTOs** are used for data transfer.  
Data models are located in the **Models/** folder.

---

## 🔧 Project Structure

The project is built on a **single-layer architecture**, with all controllers, models, views, and service logic within the same project.

**Folders:**

- Controllers/ → Handles products, categories, sliders, and newsletter operations  
- Models/ → MongoDB data models  
- Views/ → User interfaces (product list, detail, admin panel, etc.)  
- wwwroot/ → CSS, JS, and images  

**Technical Structure:**

- 💎 **Entities:** Data models  
- 💎 **DTOs:** Data transfer objects  
- 💎 **Services:** Business logic  
- 💎 **Controllers & Views:** MVC structure  
- 💎 **ViewComponents:** Reusable partial components  

Additionally, **AutoMapper** is used to simplify conversions between models, and **Bootstrap 5** ensures a modern, mobile-friendly interface.

---

## ✨ Key Features

- 🔹 NoSQL-based MongoDB data structure  
- 🔹 Management of products, categories, and sliders  
- 🔹 Automatic **20% discount coupon** sending via SMTP  
- 🔹 Advanced filtering and search system  
- 🔹 Multiple product image management  
- 🔹 Reusable **Partial View** structure  
- 🔹 Asynchronous operations (**Async/Await**)  
- 🔹 Content management via admin panel  
- 🔹 **Responsive design** for mobile devices  

---

## 📬 Email Subscription and Discount Coupon System

When a user enters their email, the system automatically generates a **20% discount code**.  
Codes are 8 characters long and sent via **Gmail SMTP**.

**Used libraries:**

```csharp
using MimeKit;
using MailKit.Net.Smtp;

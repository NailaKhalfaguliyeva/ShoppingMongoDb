# 🛍️ E-Commerce Website with MongoDB (Coza Store)

This project is a **modern e-commerce web application** built using **ASP.NET Core MVC 6.0** and **MongoDB (NoSQL)**.  
Users can browse products, filter them by categories, follow promotions through the slider, and subscribe via email to receive discount coupons.  
All product, category, and slider content can be easily managed through the admin panel.  
This project was developed under **M&Y Yazılım Eğitim Akademi Danışmanlık(M&Y Software Education Academy Consulting)**, mentored by **Murat Yucedag**.

<p align="center"> 
<img src="https://github.com/user-attachments/assets/f30ca732-1e98-4324-b1f1-8a12965517af" width="350"/> 
<img src="https://github.com/user-attachments/assets/06df3f41-0c31-47c1-852d-d2e044283870" width="350"/>
<img src="https://github.com/user-attachments/assets/41e4859a-a34b-4ef9-929e-accabd871cf1" width="350"/> 
<img src="https://github.com/user-attachments/assets/71f918f4-ae36-4635-b0d0-b607bad2d61d" width="350"/> 
<img src="https://github.com/user-attachments/assets/274955f9-94a1-40ef-a080-1318378d3642" width="350"/></p>


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

 <p align="center"> <img src="https://github.com/user-attachments/assets/f18b5c79-8ae1-4f85-8ab4-c3aab7518edd" width="200"/> </p>

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



![Screenshot 2025-10-07 011450](https://github.com/user-attachments/assets/b13afd7d-3e36-47e2-bdf4-024b8e361ff2)


**Used libraries:**

``csharp``

``using MimeKit;``

``using MailKit.Net.Smtp;``

---

## 🛠️ Admin Panel

### 📂 Category
<table>
  <tr>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/ea989723-a5d7-4eaa-9031-961b846036bb" width="600"><br>
      Create
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/55bdb3c3-43ef-47ff-ac4d-e6045b24b69f" width="600"><br>
      List
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/f7aadb18-bcb1-48da-a98f-d9d9187770c6" width="600"><br>
      Update
    </td>
  </tr>
</table>

### 🛍️ Product
<table>
  <tr>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/7eba957d-8272-412a-90ab-267feb3e8c49" width="600"><br>
      Create
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/90edf83d-ef13-44fc-92f6-d56b4bbf7eed" width="600"><br>
      List
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/122fa1dc-f11c-4484-b2c0-af4d2a5cb90f" width="600"><br>
      Update
    </td>
  </tr>
</table>

### 🖼️ ProductImages
<table>
  <tr>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/5899aca2-a3de-4780-8cce-30e51d81cba7" width="600"><br>
      Create
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/7a6cf87a-a691-4987-bc5c-43028c6f70a3" width="600"><br>
      List
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/92e541d8-5e18-4142-af3f-bc861b5d4ecd" width="600"><br>
      Update
    </td>
  </tr>
</table>

### 🎞️ Slider
<table>
  <tr>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/b8ec4bb7-dceb-42ea-abb2-0c5736fed766" width="600"><br>
      Create
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/f9dc04eb-2adb-402f-b68d-b99943ca00de" width="600"><br>
      List
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/fb5a0352-5e4b-4b05-bb74-887564d9d3c6" width="600"><br>
      <span style="color:black; font-weight:bold;">Update</span>
    </td>
  </tr>
</table






  

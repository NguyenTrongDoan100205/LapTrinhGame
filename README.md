LẬP TRÌNH GAME
---
# Mathematics in Unity: Coordinate Systems & Graphics Pipeline

## Giới thiệu

Dự án này là bài tập thực hành về toán học trong Unity, tập trung vào việc tìm hiểu hệ tọa độ Cartesian, quy tắc bàn tay trái và quy trình chuyển đổi không gian từ 3D sang 2D.

## Cấu trúc Repository

* **Assets/**: Chứa toàn bộ tài nguyên, scene bài tập và mã nguồn C#.
* **Packages/**: Quản lý các gói phụ thuộc của dự án.
* **ProjectSettings/**: Lưu trữ cấu hình thiết lập của Unity.

## Nội dung thực hiện & Minh họa

### 1. Coordinate Systems & World Space

* Thiết lập vật thể Cube tại tọa độ  trong World Space.
* Xác định hệ trục tọa độ: Trục **Y** hướng lên và trục **Z** hướng theo chiều sâu.

*Chú thích: Ảnh chụp Cube tại vị trí thiết lập và các trục X, Y, Z.*
<img width="605" height="378" alt="PhanA" src="https://github.com/user-attachments/assets/3bc8ae06-d3fa-4ca0-b946-49d018f10313" />

---

### 2. Left-Handed Coordinate System

* Kiểm chứng quy tắc bàn tay trái qua phép xoay .
* Xác định chiều quay dương tương ứng với trục tọa độ.

*Chú thích: Hướng xoay của Cube khi thay đổi Rotation Y.*

<img width="605" height="378" alt="PhanB" src="https://github.com/user-attachments/assets/162bb6d9-5fe3-4bfd-8745-fe37dff3b6eb" />

---

### 3. Local Space vs World Space

* Xây dựng mối quan hệ Cha - Con (Parent-Child).
* Quan sát sự thay đổi tọa độ khi di chuyển đối tượng cha.

*Chú thích: Bảng Inspector thể hiện sự khác biệt giữa tọa độ Local và World.*
<img width="605" height="378" alt="PhanC" src="https://github.com/user-attachments/assets/5ce5e690-8bba-409d-9df3-cce53a3f8c8e" />

---
<img width="605" height="378" alt="PhanC2" src="https://github.com/user-attachments/assets/fafd64da-0110-4eac-91ab-f50719d87b6a" />

---
<img width="605" height="376" alt="PhanC4" src="https://github.com/user-attachments/assets/7d5cc088-9738-4482-9e8d-fd97ccbc7f68" />


### 4. Graphics Pipeline & Screen Space

* Điều chỉnh Camera: Field of View (FOV) và Clipping Planes.
  <img width="605" height="378" alt="PhanD" src="https://github.com/user-attachments/assets/f6e52796-1671-4f39-aafc-2602b62ba6b8" />
---

<img width="605" height="362" alt="PhanD2" src="https://github.com/user-attachments/assets/4d826c48-3e58-4d75-9a6c-25a223cd564e" />

* Sử dụng Script `WorldToScreen.cs` để chuyển đổi sang tọa độ Pixel.
* Hình ảnh :
  <img width="605" height="504" alt="PhanE" src="https://github.com/user-attachments/assets/84af9765-3d98-4b19-ad2a-43e59304a49f" />

  ---
  
<img width="605" height="378" alt="PhanE2" src="https://github.com/user-attachments/assets/e53afd43-fd5a-429c-8af7-aa9c1b40c74d" />

---

<img width="605" height="374" alt="PhanE3" src="https://github.com/user-attachments/assets/25ba516a-c194-4028-9317-2ec2109faa3f" />

*Chú thích: Kết quả tọa độ hiển thị trên cửa sổ Console khi chạy Game.*

---

## 🛠 Hướng dẫn cài đặt

1. **Clone dự án**:
```bash
git clone [https://github.com/NguyenTrongDoan100205/LapTrinhGame]

---

# Unity Project: Space Shooter - Part 1

## Giới thiệu

Dự án này là bài thực hành xây dựng game **Space Shooter** trên engine Unity. Mục tiêu chính là làm quen với quy trình khởi tạo dự án, quản lý tài nguyên, hệ tọa độ và lập trình điều khiển nhân vật.

## Cấu trúc Repository

* 
**Assets/**: Chứa toàn bộ tài nguyên game.


* **Packages/**: Các thư viện bổ trợ từ Unity.
* **ProjectSettings/**: Các thiết lập cấu hình dự án.

---

## Các nội dung thực hiện

### 1. Khởi tạo & Cấu hình Android

* Khởi tạo dự án Unity 2D với tên gọi **SpaceShooter**.


* Chuyển đổi nền tảng phát triển sang **Android**.


* Thiết lập độ phân giải dọc **1920x1080 Portrait**.



(Gợi ý: Dùng ảnh hoặc )

### 2. Quản lý Tài nguyên (Assets)

* Import tài nguyên **Space Shooter FREE** từ Unity Asset Store.


* Tổ chức thư mục dự án chuyên nghiệp bao gồm các phần như Audio, VFX, và Sprites.



(Gợi ý: Dùng ảnh )

### 3. Thiết lập Nhân vật & Phân cấp (Hierarchy)

* Tạo Scene **Battle** để thiết lập không gian chiến đấu.


* Đưa nhân vật (Player) vào Scene và điều chỉnh **Scale = 2**.


* Thiết lập mối quan hệ Cha - Con (Parent-Child) cho nhân vật và hiệu ứng động cơ (flames).



(Gợi ý: Dùng ảnh )

### 4. Lập trình C# Scripting

* 
**Vòng đời Script**: Hiểu sự khác biệt giữa `Start()` và `Update()` qua `Debug.Log`.


* 
**Hiệu ứng Nhấp nháy**: Lập trình script `Blinking.cs` để điều khiển `spriteRenderer.enabled`.


* 
**Di chuyển theo chuột**: Sử dụng `Camera.main.ScreenToWorldPoint` để nhân vật đuổi theo vị trí chuột.



(Gợi ý: Dùng ảnh hoặc )

---

## 🛠 Hướng dẫn sử dụng

1. **Clone dự án**:
```bash
git clone [Link-Repo-Của-Bạn]

```


2. 
**Mở dự án**: Sử dụng Unity Editor (phiên bản trong ảnh là 2019.4.17f1 hoặc 2021.1.14f1).


3. 
**Chạy Game**: Mở Scene `Battle` và nhấn **Play** để thử nghiệm điều khiển nhân vật.


3. **Chạy Scene**: Mở scene bài tập và nhấn **Play**.

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

---

# Demo part1: Space Shooter Project

## Giới thiệu

Dự án này là bước đầu tiên trong quá trình xây dựng trò chơi **Space Shooter** trên nền tảng Unity. Bài thực hành tập trung vào việc làm quen với quy trình phát triển chuyên nghiệp, quản lý tài nguyên, hệ tọa độ và lập trình điều khiển đối tượng cơ bản.

## Cấu trúc Repository

Dựa trên cấu trúc tệp tin thực tế đã đẩy lên Git:

* **Assets/**: Chứa toàn bộ tài nguyên game bao gồm Sprites, Scripts và Scenes.
* **Packages/**: Quản lý các gói mở rộng của Unity.
* **ProjectSettings/**: Lưu trữ cấu hình thiết lập của dự án.
* **.gitignore**: Tệp tin loại bỏ các tệp tạm thời không cần thiết khi push lên Git.

---

## 🚀 Nội dung thực hiện & Minh họa

### 1. Khởi tạo & Cấu hình Môi trường

* Tạo dự án Unity 2D mới với tên gọi **SpaceShooter** tại thư mục dự án.


* Thiết lập môi trường phát triển cho nền tảng **Android** để tối ưu hóa cho thiết bị di động.


* Cấu hình độ phân giải màn hình dọc **1920x1080 Portrait**.



### 2. Quản lý Tài nguyên (Assets Management)

* Import gói tài nguyên **Space Shooter FREE** từ Unity Asset Store.


* Tổ chức thư mục Assets khoa học để quản lý Sprites, Audio, và VFX.



### 3. Thiết lập Hierarchy & Phân cấp đối tượng

* Tạo Scene **Battle** để thiết lập không gian trò chơi.


* Đưa nhân vật (Player) vào Scene và điều chỉnh kích thước lớn hơn (**Scale = 2**).


* Thiết lập mối quan hệ **Parent-Child** để gắn hiệu ứng lửa (flames) vào tàu chiến.


### 4. Lập trình C# Scripting

**Vòng đời Script**: Phân biệt hàm `Start()` (chạy khi bắt đầu) và `Update()` (chạy mỗi khung hình).

**Hiệu ứng Nhấp nháy**: Lập trình script `Blinking.cs` để điều khiển trạng thái hiển thị của động cơ.

**Điều khiển nhân vật**: Sử dụng `Input.mousePosition` để nhân vật di chuyển theo vị trí chuột.

![MayBay](https://github.com/user-attachments/assets/4895102a-ea69-420d-a1e0-4e43a810e1d0)

---

![MayBay1](https://github.com/user-attachments/assets/2c82d77c-48eb-48d1-91ae-37c4b5e65afe)

## 🛠 Hướng dẫn cài đặt

1. **Yêu cầu**: Unity Editor phiên bản **2019.4.17f1** hoặc **2021.1.14f1**.


2. **Clone dự án**:

```bash
git clone https://github.com/NguyenTrongDoan10205/LapTrinhGame

```

3. **Mở dự án**: Sử dụng Unity Hub để `Add` thư mục dự án và mở Scene `Battle`.

Dưới đây là nội dung `README.md` đã được chèn trực tiếp đường dẫn hiển thị cho hai tệp ảnh `Demo2A1.jpg` và `Demo2A2.jpg` để chúng tự động hiển thị trên GitHub của bạn.

---

# Space Shooter Project - Part 2

Dự án này tập trung vào việc xây dựng hệ thống chiến đấu cơ bản cho tàu vũ trụ trong Unity. Nội dung hướng dẫn cách tạo đạn từ Sprite , quản lý đối tượng bằng Prefab và thiết lập cơ chế bắn tự động.

## Mục tiêu (Objectives)

* Làm quen với việc xử lý Sprite và đối tượng trong không gian 2D.


* Hiểu cách vận hành của hệ tọa độ để di chuyển đối tượng.


* Quản lý tài nguyên dự án thông qua hệ thống Prefabs.


* Xử lý sự kiện đầu vào từ người dùng để điều khiển hành động bắn.



## Hướng dẫn thực hiện

### 1. Tạo đối tượng đạn từ Sprite

* Chọn hình ảnh đạn từ bộ tài nguyên dự án, cụ thể là các tệp `vulcan` trong thư mục `FX`.


* Kéo và thả Sprite vào cửa sổ **Scene** để tạo một Game Object mới.



### 2. Cấu hình đạn di chuyển (Bullet Movement)

* Gắn thành phần điều khiển vào đối tượng đạn.


* Thiết lập thông số **Fly Speed** trong cửa sổ **Inspector** (ví dụ: `5`) để đạn tự động bay lên theo trục Y.



### 3. Tạo Bullet Prefab

* Để tối ưu hóa việc tạo nhiều viên đạn, kéo đối tượng đạn từ cửa sổ **Hierarchy** vào thư mục `Prefabs` trong cửa sổ **Project**.


* Việc này giúp biến đối tượng thành một "khuôn mẫu" có thể tái sử dụng vô số lần.



### 4. Thiết lập hệ thống bắn tự động

* Chọn đối tượng tàu người chơi `player_b_m`.


* Gắn thành phần **Player Shooting** và kéo **Bullet Prefab** vào ô tham chiếu tương ứng.


* Điều chỉnh **Shooting Interval** (ví dụ: `0.1`) để xác định tốc độ ra đạn khi giữ chuột trái.



## 🚀 Kết quả (Results)

Sau khi hoàn thành, tàu vũ trụ có thể bắn đạn liên tục theo hướng di chuyển của người chơi với tốc độ được cấu hình sẵn.

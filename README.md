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

---

### 2. Left-Handed Coordinate System

* Kiểm chứng quy tắc bàn tay trái qua phép xoay .
* Xác định chiều quay dương tương ứng với trục tọa độ.

*Chú thích: Hướng xoay của Cube khi thay đổi Rotation Y.*

---

### 3. Local Space vs World Space

* Xây dựng mối quan hệ Cha - Con (Parent-Child).
* Quan sát sự thay đổi tọa độ khi di chuyển đối tượng cha.

*Chú thích: Bảng Inspector thể hiện sự khác biệt giữa tọa độ Local và World.*

---

### 4. Graphics Pipeline & Screen Space

* Điều chỉnh Camera: Field of View (FOV) và Clipping Planes.
* Sử dụng Script `WorldToScreen.cs` để chuyển đổi sang tọa độ Pixel.

*Chú thích: Kết quả tọa độ hiển thị trên cửa sổ Console khi chạy Game.*

---

## 🛠 Hướng dẫn cài đặt

1. **Clone dự án**:
```bash
git clone [https://github.com/NguyenTrongDoan100205/LapTrinhGame]

```


2. **Mở dự án**: Sử dụng Unity Editor để mở thư mục `Mathematics in Unity`.
3. **Chạy Scene**: Mở scene bài tập và nhấn **Play**.

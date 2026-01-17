#LẬP TRÌNH GAME
---

# Mathematics in Unity: Coordinate Systems & Graphics Pipeline

## Giới thiệu

Dự án này là bài tập thực hành về toán học trong Unity, tập trung vào việc tìm hiểu hệ tọa độ Cartesian, quy tắc bàn tay trái (Left-Handed Coordinate System) và quy trình chuyển đổi không gian từ 3D sang 2D (Graphics Pipeline).

## Cấu trúc Repository

Dựa trên cấu trúc đã push lên Git, dự án bao gồm các thành phần cốt lõi của một Unity Project:

* **Assets/**: Chứa toàn bộ tài nguyên, scene bài tập và mã nguồn C#.
* **Packages/**: Quản lý các gói phụ thuộc của dự án.
* **ProjectSettings/**: Lưu trữ cấu hình thiết lập của Unity.
* **.gitignore**: Tệp cấu hình loại bỏ các dữ liệu rác và tệp tạm thời khi push lên Git.

## 🚀 Nội dung thực hiện

### 1. Coordinate Systems & World Space

* Thiết lập vật thể Cube tại tọa độ  trong không gian thế giới (World Space).
* Xác định hệ trục tọa độ: Trục **Y** hướng lên trên và trục **Z** hướng theo chiều sâu.

### 2. Left-Handed Coordinate System

* Kiểm chứng quy tắc bàn tay trái thông qua phép xoay vật thể.
* Xác định chiều quay dương tương ứng với trục tọa độ trong Unity.

### 3. Local Space vs World Space

* Xây dựng mối quan hệ Cha - Con (Parent-Child) giữa các GameObject.
* Phân tích sự thay đổi của tọa độ tuyệt đối (World) và tọa độ tương đối (Local) khi đối tượng cha di chuyển.

### 4. Graphics Pipeline & Screen Space

* Tìm hiểu cơ chế hoạt động của Camera qua các thông số: Field of View (FOV), Near/Far Clip Plane.
* Triển khai Script `WorldToScreen.cs` để chuyển đổi tọa độ từ không gian 3D sang tọa độ Pixel (Screen Space).

## 🛠 Hướng dẫn cài đặt

1. **Yêu cầu**: Unity Editor (phiên bản 2022.3.x hoặc mới hơn).
2. **Clone dự án**:
```bash
git clone

```
3. **Mở dự án**: Sử dụng Unity Hub để `Add` thư mục `Mathematics in Unity` vào danh sách project.
4. **Chạy Demo**: Mở Scene chính trong thư mục `Assets`, nhấn **Play** và theo dõi tọa độ hiển thị tại cửa sổ **Console**.

---

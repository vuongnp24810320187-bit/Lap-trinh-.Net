# Bài Ôn Tập 4 – Đặt Vị Trí Ngồi (Seat Booking)

## Thông Tin Sinh Viên

| Thông tin | Nội dung |
|-----------|----------|
| **Họ và tên** | Nguyễn Phúc Vượng |
| **Mã số sinh viên** | 24810320187 |
| **Lớp** | D198QTANM1 |
| **Môn học** | Lập trình .Net / Windows Forms |
| **Tên bài tập** | Đặt Vị Trí Ngồi (Seat Booking System) |

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** mô phỏng hệ thống đặt chỗ ngồi (ví dụ: rạp chiếu phim, quán cà phê). Giao diện hiển thị lưới 4×5 ghế, người dùng có thể chọn ghế trống, xem tổng tiền và xác nhận đặt chỗ.

---

## Chức Năng Chính

| Chức năng | Mô tả |
|-----------|-------|
| **Hiển thị sơ đồ ghế** | Lưới 4 hàng × 5 cột (20 vị trí), tự sinh bằng code |
| **Chọn / Bỏ chọn ghế** | Click vào ghế trống để chọn / bỏ chọn |
| **Ghế bị khóa** | Vị trí 3, 8, 14, 19 đã có người đặt (màu đỏ) |
| **Chọn khung giờ** | ComboBox: Bình thường (100.000đ) / Cao điểm (150.000đ) |
| **Tạm tính tiền** | Tự động cập nhật khi chọn ghế hoặc đổi khung giờ |
| **Xác nhận đặt** | Hiển thị xác nhận, sau đó khóa ghế đã đặt (màu đỏ) |
| **Hủy chọn** | Bỏ tất cả ghế đang chọn, về trạng thái ban đầu |

---

## Màu Sắc Trạng Thái Ghế

| Màu | Trạng thái |
|-----|-----------|
| ⬜ Trắng (WhiteSmoke) | Ghế trống, chưa chọn |
| 🟩 Xanh lá (LightGreen) | Ghế đang được chọn |
| 🟥 Đỏ (IndianRed) | Ghế đã đặt / bị khóa |

---

## Bảng Giá

| Khung giờ | Giá mỗi vị trí |
|-----------|---------------|
| Bình thường | 100.000 VNĐ |
| Cao điểm | 150.000 VNĐ |

---

## Công Nghệ Sử Dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework – Windows Forms
- **IDE:** Visual Studio 2022

---

## Các Control Sử Dụng

| Control | Mục đích |
|---------|----------|
| `TableLayoutPanel` | Chứa lưới ghế 4×5 |
| `Button` (sinh động) | Mỗi ghế là một Button được tạo bằng code |
| `ComboBox` | Chọn khung giờ |
| `Label` | Hiển thị số ghế đang chọn và tổng tiền |
| `Button` | Xác nhận đặt / Hủy chọn |

---

## Cấu Trúc Dự Án

```
bt on tap 4/
├── bt on tap 4.slnx          # Solution file
└── bt on tap 4/
    ├── Form1.cs               # Logic chính (sinh ghế, chọn, đặt)
    ├── Form1.Designer.cs      # Thiết kế giao diện tự sinh
    ├── Program.cs             # Điểm khởi chạy ứng dụng
    ├── App.config
    └── Properties/
```

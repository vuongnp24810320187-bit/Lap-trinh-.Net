# Bài Ôn Tập 4 – Đặt Vị Trí Ngồi (Seat Booking)

## Thông Tin Sinh Viên

- **Họ và tên:** Nguyễn Phúc Vượng
- **Mã số sinh viên:** 24810320187
- **Lớp:** D198QTANM1
- **Môn học:** Lập trình .Net / Windows Forms
- **Tên bài tập:** Đặt Vị Trí Ngồi (Seat Booking System)

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** mô phỏng hệ thống đặt chỗ ngồi. Giao diện hiển thị lưới 4×5 ghế, người dùng có thể chọn ghế trống, xem tổng tiền và xác nhận đặt chỗ.

---

## Chức Năng Chính

- Hiển thị sơ đồ ghế dạng lưới 4 hàng × 5 cột (20 vị trí), tự sinh bằng code
- Click vào ghế trống để chọn / bỏ chọn
- Các vị trí 3, 8, 14, 19 đã bị khóa (màu đỏ, không thể chọn)
- Chọn khung giờ: Bình thường (100.000đ/vị trí) hoặc Cao điểm (150.000đ/vị trí)
- Tự động cập nhật tổng tiền khi chọn ghế hoặc đổi khung giờ
- Xác nhận đặt chỗ: hiển thị xác nhận rồi khóa ghế đã đặt
- Hủy chọn: bỏ tất cả ghế đang chọn

---

## Màu Sắc Trạng Thái Ghế

- **Trắng (WhiteSmoke):** Ghế trống, chưa chọn
- **Xanh lá (LightGreen):** Ghế đang được chọn
- **Đỏ (IndianRed):** Ghế đã đặt / bị khóa

---

## Công Nghệ Sử Dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework – Windows Forms
- **IDE:** Visual Studio 2022

---

## Cấu Trúc Dự Án

```
bt on tap 4/
├── bt on tap 4.slnx
└── bt on tap 4/
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Program.cs
    ├── App.config
    └── Properties/
```

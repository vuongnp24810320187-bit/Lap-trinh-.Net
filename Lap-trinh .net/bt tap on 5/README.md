# Bài Tập Ôn 5 – Hóa Đơn Giao Hàng (Delivery Invoice)

## Thông Tin Sinh Viên

| Thông tin | Nội dung |
|-----------|----------|
| **Họ và tên** | Nguyễn Phúc Vượng |
| **Mã số sinh viên** | 24810320187 |
| **Lớp** | D198QTANM1 |
| **Môn học** | Lập trình .Net / Windows Forms |
| **Tên bài tập** | Hóa Đơn Giao Hàng (Delivery Invoice) |

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** mô phỏng hệ thống tạo hóa đơn giao hàng. Người dùng nhập thông tin khách hàng và danh sách hàng hóa vào `DataGridView`. Ứng dụng tự động tính thành tiền từng dòng, cập nhật tổng số lượng, tổng trọng lượng và tổng tiền ở thanh trạng thái theo thời gian thực.

---

## Chức Năng Chính

| Chức năng | Mô tả |
|-----------|-------|
| **Đồng hồ thời gian thực** | Hiển thị ngày giờ hiện tại ở StatusBar, cập nhật mỗi giây |
| **Nhập thông tin khách hàng** | Tên khách hàng và địa chỉ (bắt buộc nhập) |
| **Danh sách hàng hóa (DataGridView)** | Tên hàng, số lượng, trọng lượng, đơn giá, thành tiền |
| **Tự động tính thành tiền** | Tự tính = Số lượng × Đơn giá khi thay đổi dữ liệu |
| **Tổng hợp tự động** | Tổng SL / Tổng KL / Tổng tiền cập nhật tức thì |
| **Thêm dòng mới (F2)** | Nhấn `F2` để thêm dòng mới vào lưới |
| **Xóa dòng (Delete)** | Chọn dòng rồi nhấn `Delete` để xóa |
| **Kiểm tra hợp lệ** | Số lượng và trọng lượng phải > 0; tên, địa chỉ không trống |

---

## Phím Tắt

| Phím | Chức năng |
|------|-----------|
| `F2` | Thêm dòng mới vào DataGridView |
| `Delete` | Xóa dòng đang chọn trong DataGridView |

---

## Công Nghệ Sử Dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework – Windows Forms
- **IDE:** Visual Studio 2022

---

## Các Control Sử Dụng

| Control | Mục đích |
|---------|----------|
| `TextBox` | Nhập tên khách hàng, địa chỉ |
| `DataGridView` | Danh sách hàng hóa (tên, SL, KL, đơn giá, thành tiền) |
| `StatusStrip` | Hiển thị đồng hồ, tổng SL, tổng KL, tổng tiền |
| `Timer` | Cập nhật đồng hồ thời gian thực mỗi giây |
| `ErrorProvider` | Hiển thị lỗi validation trực tiếp trên form |

---

## Cấu Trúc Dự Án

```
bt tap on 5/
├── bt tap on 5.slnx          # Solution file
└── bt tap on 5/
    ├── Form1.cs               # Logic chính: DataGridView, Timer, tính toán
    ├── Form1.Designer.cs      # Thiết kế giao diện tự sinh
    ├── Form1.resx             # Resource của Form
    ├── Program.cs             # Điểm khởi chạy ứng dụng
    ├── App.config
    └── Properties/
```

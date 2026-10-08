# Bài Ôn Tập 2 – Phiếu Hỗ Trợ Kỹ Thuật (IT Support Ticket)

## Thông Tin Sinh Viên

| Thông tin | Nội dung |
|-----------|----------|
| **Họ và tên** | Nguyễn Phúc Vượng |
| **Mã số sinh viên** | 24810320187 |
| **Lớp** | D198QTANM1 |
| **Môn học** | Lập trình .Net / Windows Forms |
| **Tên bài tập** | Phiếu Hỗ Trợ Kỹ Thuật (IT Support Ticket) |

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** mô phỏng hệ thống tạo phiếu yêu cầu hỗ trợ kỹ thuật nội bộ. Người dùng nhập thông tin sự cố, chọn mức độ ưu tiên, loại sự cố và thiết bị bị ảnh hưởng, sau đó gửi phiếu để hiển thị tóm tắt thông tin.

---

## Chức Năng Chính

| Chức năng | Mô tả |
|-----------|-------|
| **Nhập thông tin phiếu** | Mã phiếu, người yêu cầu, ngày ghi nhận |
| **Chọn mức độ ưu tiên** | RadioButton: Thấp / Trung bình / Khẩn cấp |
| **Chọn loại sự cố** | ComboBox với các loại sự cố IT |
| **Chọn thiết bị ảnh hưởng** | CheckBox: Desktop / Laptop / Printer / Phone |
| **Tải ảnh lỗi** | OpenFileDialog cho phép chọn ảnh `.jpg` / `.png` |
| **Gửi phiếu** | Kiểm tra hợp lệ và hiển thị tóm tắt bằng MessageBox |
| **Reset** | Xóa toàn bộ form về trạng thái ban đầu |

---

## Kiểm Tra Hợp Lệ (Validation)

- Mã phiếu và người yêu cầu không được để trống
- Phải chọn loại sự cố
- Phải chọn ít nhất một mức độ ưu tiên

---

## Công Nghệ Sử Dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework – Windows Forms
- **IDE:** Visual Studio 2022

---

## Các Control Sử Dụng

| Control | Mục đích |
|---------|----------|
| `TextBox` | Nhập mã phiếu, người yêu cầu |
| `DateTimePicker` | Chọn ngày ghi nhận |
| `RadioButton` | Chọn mức độ ưu tiên |
| `ComboBox` | Chọn loại sự cố |
| `CheckBox` | Chọn thiết bị ảnh hưởng |
| `PictureBox` | Hiển thị ảnh lỗi đã tải |
| `OpenFileDialog` | Duyệt và chọn file ảnh |
| `Button` | Tải ảnh / Gửi phiếu / Reset |

---

## Cấu Trúc Dự Án

```
bt on tap 2/
├── bt on tap 2.slnx          # Solution file
└── bt on tap 2/
    ├── Form1.cs               # Logic chính của form
    ├── Form1.Designer.cs      # Thiết kế giao diện tự sinh
    ├── Program.cs             # Điểm khởi chạy ứng dụng
    ├── App.config
    └── Properties/
```

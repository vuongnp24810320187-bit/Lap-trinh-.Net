# Bài Ôn Tập 2 – Phiếu Hỗ Trợ Kỹ Thuật (IT Support Ticket)

## Thông Tin Sinh Viên

- **Họ và tên:** Nguyễn Phúc Vượng
- **Mã số sinh viên:** 24810320187
- **Lớp:** D198QTANM1
- **Môn học:** Lập trình .Net / Windows Forms
- **Tên bài tập:** Phiếu Hỗ Trợ Kỹ Thuật (IT Support Ticket)

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** mô phỏng hệ thống tạo phiếu yêu cầu hỗ trợ kỹ thuật nội bộ. Người dùng nhập thông tin sự cố, chọn mức độ ưu tiên, loại sự cố và thiết bị bị ảnh hưởng, sau đó gửi phiếu để hiển thị tóm tắt thông tin.

---

## Chức Năng Chính

- Nhập thông tin phiếu: mã phiếu, người yêu cầu, ngày ghi nhận
- Chọn mức độ ưu tiên bằng RadioButton: Thấp / Trung bình / Khẩn cấp
- Chọn loại sự cố qua ComboBox
- Chọn thiết bị bị ảnh hưởng qua CheckBox: Desktop / Laptop / Printer / Phone
- Tải ảnh lỗi bằng OpenFileDialog (hỗ trợ `.jpg`, `.png`)
- Gửi phiếu: kiểm tra hợp lệ và hiển thị tóm tắt bằng MessageBox
- Reset: xóa toàn bộ form về trạng thái ban đầu

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

## Cấu Trúc Dự Án

```
bt on tap 2/
├── bt on tap 2.slnx
└── bt on tap 2/
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Program.cs
    ├── App.config
    └── Properties/
```

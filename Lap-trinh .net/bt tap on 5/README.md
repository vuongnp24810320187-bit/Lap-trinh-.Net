# Bài Tập Ôn 5 – Hóa Đơn Giao Hàng (Delivery Invoice)

## Thông Tin Sinh Viên

- **Họ và tên:** Nguyễn Phúc Vượng
- **Mã số sinh viên:** 24810320187
- **Lớp:** D198QTANM1
- **Môn học:** Lập trình .Net / Windows Forms
- **Tên bài tập:** Hóa Đơn Giao Hàng (Delivery Invoice)

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** mô phỏng hệ thống tạo hóa đơn giao hàng. Người dùng nhập thông tin khách hàng và danh sách hàng hóa vào `DataGridView`. Ứng dụng tự động tính thành tiền từng dòng và cập nhật tổng số lượng, tổng trọng lượng, tổng tiền theo thời gian thực.

---

## Chức Năng Chính

- Hiển thị đồng hồ thời gian thực ở thanh trạng thái (cập nhật mỗi giây)
- Nhập tên khách hàng và địa chỉ (bắt buộc)
- Nhập danh sách hàng hóa qua DataGridView: tên hàng, số lượng, trọng lượng, đơn giá, thành tiền
- Tự động tính thành tiền = Số lượng × Đơn giá khi thay đổi dữ liệu
- Tự động cập nhật tổng số lượng, tổng trọng lượng, tổng tiền
- Nhấn `F2` để thêm dòng mới vào DataGridView
- Chọn dòng rồi nhấn `Delete` để xóa dòng
- Kiểm tra hợp lệ: số lượng và trọng lượng phải > 0; tên và địa chỉ không được trống

---

## Phím Tắt

- `F2` – Thêm dòng mới vào DataGridView
- `Delete` – Xóa dòng đang chọn trong DataGridView

---

## Công Nghệ Sử Dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework – Windows Forms
- **IDE:** Visual Studio 2022

---

## Cấu Trúc Dự Án

```
bt tap on 5/
├── bt tap on 5.slnx
└── bt tap on 5/
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── Program.cs
    ├── App.config
    └── Properties/
```

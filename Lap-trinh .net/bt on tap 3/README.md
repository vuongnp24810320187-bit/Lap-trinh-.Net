# Bài Ôn Tập 3 – Quản Lý Danh Sách Vật Tư (Material Management)

## Thông Tin Sinh Viên

- **Họ và tên:** Nguyễn Phúc Vượng
- **Mã số sinh viên:** 24810320187
- **Lớp:** D198QTANM1
- **Môn học:** Lập trình .Net / Windows Forms
- **Tên bài tập:** Quản Lý Danh Sách Vật Tư (Material List Management)

---

## Mô Tả Bài Tập

Ứng dụng **Windows Forms (.NET Framework)** cho phép quản lý danh sách vật tư bao gồm: thêm mới, cập nhật, xóa từng dòng hoặc xóa toàn bộ danh sách. Dữ liệu được hiển thị trong `ListView` với đầy đủ thông tin mã, tên, đơn vị và đơn giá.

---

## Chức Năng Chính

- Thêm mới vật tư vào danh sách (kiểm tra mã trùng)
- Cập nhật thông tin vật tư đang chọn trong ListView
- Xóa vật tư đang được chọn (có xác nhận)
- Xóa toàn bộ danh sách (có xác nhận)
- Click vào ListView để load dữ liệu lên form nhập

---

## Mô Hình Dữ Liệu

```csharp
class VatTu {
    string Ma        // Mã vật tư (duy nhất)
    string Ten       // Tên vật tư
    string DonVi     // Đơn vị tính (cái, kg, hộp, ...)
    decimal DonGia   // Đơn giá (không âm)
}
```

---

## Kiểm Tra Hợp Lệ (Validation)

- Mã vật tư và tên vật tư không được để trống
- Phải chọn đơn vị tính
- Đơn giá phải là số không âm hợp lệ
- Mã vật tư không được trùng trong danh sách

---

## Công Nghệ Sử Dụng

- **Ngôn ngữ:** C#
- **Framework:** .NET Framework – Windows Forms
- **IDE:** Visual Studio 2022

---

## Cấu Trúc Dự Án

```
bt on tap 3/
├── bt on tap 3.slnx
└── bt on tap 3/
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Program.cs
    ├── App.config
    └── Properties/
```

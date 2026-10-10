# Bài 5.4 – Quản Lý Nhân Viên với TreeView & ListView (10/10)

## Mô tả
Ứng dụng Windows Forms C# xây dựng hệ thống **quản lý nhân viên** sử dụng `TreeView` để hiển thị cấu trúc phòng ban/nhóm và `ListView` để hiển thị danh sách nhân viên theo bộ phận được chọn.

## Chức năng
- 🌳 **TreeView** hiển thị cây tổ chức: Công ty → Phòng ban → Nhóm
- 📋 **ListView** lọc và hiển thị nhân viên theo phòng/nhóm được chọn
- 🔄 **Chế độ xem** linh hoạt: Details / SmallIcon / LargeIcon / Tile / List
- 🏢 Click vào node phòng ban → hiển thị toàn bộ nhân viên phòng đó
- 👥 Click vào node nhóm → hiển thị chỉ nhân viên của nhóm đó

## Cấu trúc tổ chức
```
Công ty ABC
├── Phòng Công nghệ thông tin
│   ├── Phát triển phần mềm
│   ├── Đảm bảo chất lượng
│   └── Hạ tầng hệ thống
├── Phòng Kinh doanh
│   ├── Khách hàng doanh nghiệp
│   └── Khách hàng cá nhân
└── Phòng Nhân sự
    ├── Tuyển dụng
    └── Chế độ và phúc lợi
```

## Thông tin nhân viên hiển thị
| Cột | Nội dung |
|-----|---------|
| Mã NV | Mã định danh |
| Họ và tên | Tên đầy đủ |
| Chức vụ | Vị trí công việc |
| Ngày vào làm | Định dạng dd/MM/yyyy |

## Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework)
- **UI:** Windows Forms
- **Controls:** TreeView, ListView, ComboBox, ImageList

## Giao diện

![Màn hình chính - Details view](bai%205.4.1.png)

![Chọn phòng ban](bai%205.4.2.png)

![Chọn nhóm](bai%205.4.3.png)

![SmallIcon view](bai%205.4.4.png)

![LargeIcon view](bai%205.4.5.png)

![Tile view](bai%205.4.6.png)

![List view](bai%205.4.7.png)

## Cách chạy
1. Mở file `bai 5.4 10-10.slnx` bằng Visual Studio
2. Nhấn `F5` hoặc `Ctrl+F5` để chạy

# Bài 5.3 – Quản Lý Sản Phẩm với DataGridView (10/10)

## Mô tả
Ứng dụng Windows Forms C# xây dựng hệ thống **quản lý sản phẩm** sử dụng `DataGridView` kết hợp `BindingSource` để hiển thị và thao tác dữ liệu.

## Chức năng
- ➕ **Thêm** sản phẩm mới (kiểm tra trùng mã sản phẩm)
- ✏️ **Sửa** thông tin sản phẩm đang được chọn trên lưới
- ❌ **Xóa** sản phẩm (có xác nhận trước khi xóa)
- 🔍 **Tìm kiếm** sản phẩm theo tên (không phân biệt hoa thường)
- 🖱️ Click vào dòng trên `DataGridView` tự động điền thông tin vào form

## Thông tin sản phẩm
| Trường | Mô tả |
|--------|-------|
| Mã SP | Mã định danh duy nhất |
| Tên SP | Tên sản phẩm |
| Đơn giá | Giá (số thực không âm) |
| Số lượng | Số lượng tồn kho (số nguyên không âm) |
| Danh mục | Phân loại sản phẩm |

## Validation
- Mã SP và Tên SP không được để trống
- Đơn giá phải là số không âm
- Số lượng phải là số nguyên không âm
- Mã SP không được trùng với sản phẩm đã có

## Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework)
- **UI:** Windows Forms
- **Controls:** DataGridView, BindingSource, TextBox, Button

## Giao diện

![Màn hình chính](bai%205.3.1.png)

![Thêm sản phẩm](bai%205.3.2.png)

![Sửa sản phẩm](bai%205.3.3.png)

![Xóa sản phẩm](bai%205.3.4.png)

![Tìm kiếm sản phẩm](bai%205.3.5.png)

## Cách chạy
1. Mở file `bai 5.3 10-10.slnx` bằng Visual Studio
2. Nhấn `F5` hoặc `Ctrl+F5` để chạy

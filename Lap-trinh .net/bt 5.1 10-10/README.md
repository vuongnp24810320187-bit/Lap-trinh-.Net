# Bài tập 5.1 – Form Đăng Ký Tài Khoản (10/10)

## Mô tả
Ứng dụng Windows Forms C# xây dựng form đăng ký tài khoản có **kiểm tra hợp lệ (validation)** đầy đủ bằng `ErrorProvider`.

## Chức năng
- ✅ Kiểm tra tên đăng nhập không được để trống
- ✅ Kiểm tra mật khẩu không được để trống
- ✅ Kiểm tra mật khẩu nhập lại phải khớp
- ✅ Kiểm tra tuổi phải đủ 18 trở lên (dựa vào `DateTimePicker`)
- ✅ Bắt buộc chọn giới tính (`RadioButton`)
- ✅ Bắt buộc đồng ý điều khoản dịch vụ (`CheckBox`)
- ✅ Nút **Reset** xóa toàn bộ form về trạng thái ban đầu

## Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework)
- **UI:** Windows Forms
- **Controls:** TextBox, DateTimePicker, RadioButton, CheckBox, ErrorProvider, Button

## Giao diện

![Màn hình đăng ký](bai%205.1.1.png)

![Kiểm tra lỗi validation](bai%205.1.2.png)

![Kiểm tra tuổi](bai%205.1.3.png)

![Đăng ký thành công](bai%205.1.4.png)

## Cách chạy
1. Mở file `bt 5.1 10-10.slnx` bằng Visual Studio
2. Nhấn `F5` hoặc `Ctrl+F5` để chạy

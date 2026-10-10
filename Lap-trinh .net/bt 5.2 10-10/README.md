# Bài tập 5.2 – Form Đăng Ký Dịch Vụ Y Tế (10/10)

## Mô tả
Ứng dụng Windows Forms C# mô phỏng hệ thống **đăng ký dịch vụ y tế** tại phòng khám. Người dùng có thể chọn các dịch vụ theo danh mục và hệ thống tự động tính tổng tiền cần thanh toán.

## Chức năng
- 📋 Chọn danh mục dịch vụ từ `ComboBox` (Khám bệnh, Xét nghiệm, Chụp X-Quang, Vắc-xin)
- ➕ Thêm dịch vụ vào danh sách đã chọn (click hoặc double-click)
- ➖ Xóa dịch vụ khỏi danh sách đã chọn
- 🗑️ Xóa toàn bộ dịch vụ đã chọn
- 💰 Tự động tính **tạm tính** và **thanh toán** (sau khi trừ chiết khấu)
- 🔢 Điều chỉnh % chiết khấu bằng `NumericUpDown`

## Danh sách dịch vụ
| Danh mục | Dịch vụ | Giá |
|----------|---------|-----|
| Khám bệnh | Khám tổng quát | 150.000 ₫ |
| Khám bệnh | Khám chuyên khoa | 100.000 ₫ |
| Xét nghiệm | Xét nghiệm công thức máu | 120.000 ₫ |
| Xét nghiệm | Xét nghiệm đường huyết | 50.000 ₫ |
| Xét nghiệm | Xét nghiệm nước tiểu | 70.000 ₫ |
| Chụp X-Quang | X-Quang ngực | 200.000 ₫ |
| Chụp X-Quang | X-Quang bàn tay | 150.000 ₫ |
| Vắc-xin | Vắc-xin cúm | 350.000 ₫ |
| Vắc-xin | Vắc-xin viêm gan B | 250.000 ₫ |

## Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework)
- **UI:** Windows Forms
- **Controls:** ComboBox, ListBox, NumericUpDown, Label, Button

## Giao diện

![Màn hình chính](bai%205.2.1.png)

![Chọn dịch vụ và tính tiền](bai%205.2.2.png)

## Cách chạy
1. Mở file `bt 5.2 10-10.slnx` bằng Visual Studio
2. Nhấn `F5` hoặc `Ctrl+F5` để chạy

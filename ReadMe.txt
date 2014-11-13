1. Giới thiệu: Website bán laptop

2. Kiến trúc:
+ WCF
+ ASP.NET 
+ Winform
+ SQL Server

3. Thiết kế, chức năng
- Website được chia thành 2 phần: người dùng và phần admin

3.1 Phần người dùng: sử dụng trực tiếp trên website
   3.1.1 Sản phẩm
       3.1.1.1 Xem sản phẩm (sản phẩm mới, tất cả sản phẩm, xem sản phẩm theo nhà cung cấp) - có hiển thị số lượng hiện tại đang có trong kho
       3.1.1.2 Xem chi tiết sản phẩm
       3.1.1.3 Tìm kiếm sản phẩm (cơ bản, nâng cao)
   3.1.2 Tài khoản
       3.1.2.1 Đăng ký tài khoản 
       3.1.2.2 Đăng nhập tài khoản
       3.1.2.2 Chỉnh sửa thông tin tài khoản
       3.1.2.2 Đổi mật khẩu
   3.1.3 Đặt hàng online
       3.1.3.1 Đưa sản phẩm vào giỏ hàng
       3.1.3.2 Thực hiện đặt hàng (nếu đã đăng nhập sẽ tự động cập nhật thông tin khách hàng, nếu chưa đăng nhập có thể nhập thông tin mà k cần đăng nhập)
   3.1.4 Thống kê tổng số lượt truy cập và tổng số lượng đang online

3.2 Phần admin: sử dụng trên winform
   3.2.1 Quản lý sản phẩm
      3.2.1.0 Xem sản phẩm	
      3.2.1.1 Thêm sản phẩm
      3.2.1.2 Sửa sản phẩm
      3.2.1.3 Xóa sản phẩm
      3.2.1.4 Tìm kiếm sản phẩm (theo tên, theo nhà cung cấp và đơn giá)
   3.2.2 Quản lý nhà sản xuất
      3.2.2.0 Xem nhà sản xuất
      3.2.2.1 Thêm nhà sản xuất
      3.2.2.2 Sửa nhà sản xuất
      3.2.2.3 Xóa nhà sản xuất
   3.2.3 Quản lý đơn đặt hàng
      3.2.3.0 Xem danh sách đơn đặt hàng, chi tiết đơn đặt hàng theo từng đơn đặt hàng
      3.2.3.1 Sửa đơn đặt hàng
      3.2.3.2 Xóa đơn đặt hàng
      3.2.3.3 Tìm kiếm đơn đặt hàng (theo mã, theo tình trạng và theo ngày đặt hàng)
   3.2.4 Quản lý phiếu nhập hàng
      3.2.4.0 Xem danh sách phiếu nhập hàng
      3.2.4.1 Thêm phiếu nhập hàng theo nhà cung cấp, cập nhật số lượng sản phẩm - đơn giá tương ứng
      3.2.4.2 Sửa phiếu nhập hàng
      3.2.4.3 Tìm kiếm phiếu nhập hàng (theo mã, nhà cung cấp, ngày nhập hàng)
   3.2.5 Quản lý tồn kho
      3.2.5.0 Xem danh sách tồn kho, số lượng tồn kho của sản phẩm theo thời gian
      3.2.5.1 Lọc tồn kho theo sản phẩn ID, số lượng tồn, tháng năm, từ ngày đến ngày
      3.2.5.2 Xuất báo cáo tồn kho (tất cả và theo điều kiện lọc)

4. Cách cài đặt, cấu hình
- Yêu cầu cài đặt Crytal Report để xuất báo cáo trong chương trình
- Sử dụng Ajax
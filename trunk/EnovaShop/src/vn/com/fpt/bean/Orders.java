package vn.com.fpt.bean;

public class Orders {
	private int orderId;
	private String invoiceCode;
	private double totalPrice;
	private double feeDelivery;
	private double finalPrice;
	private Customers customer;
	private String address;
	private String phone;
	private City city;
	private Coupon coupon;
	private int payementId;
	private String methodDelivery;
	private String orderStatus;
	private String exportBill;
	public int getOrderId() {
		return orderId;
	}
	public void setOrderId(int orderId) {
		this.orderId = orderId;
	}
	public String getInvoiceCode() {
		return invoiceCode;
	}
	public void setInvoiceCode(String invoiceCode) {
		this.invoiceCode = invoiceCode;
	}
	public double getTotalPrice() {
		return totalPrice;
	}
	public void setTotalPrice(double totalPrice) {
		this.totalPrice = totalPrice;
	}
	public double getFeeDelivery() {
		return feeDelivery;
	}
	public void setFeeDelivery(double feeDelivery) {
		this.feeDelivery = feeDelivery;
	}
	public double getFinalPrice() {
		return finalPrice;
	}
	public void setFinalPrice(double finalPrice) {
		this.finalPrice = finalPrice;
	}
	public Customers getCustomer() {
		return customer;
	}
	public void setCustomer(Customers customer) {
		this.customer = customer;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public City getCity() {
		return city;
	}
	public void setCity(City city) {
		this.city = city;
	}
	public Coupon getCoupon() {
		return coupon;
	}
	public void setCoupon(Coupon coupon) {
		this.coupon = coupon;
	}
	public int getPayementId() {
		return payementId;
	}
	public void setPayementId(int payementId) {
		this.payementId = payementId;
	}
	public String getMethodDelivery() {
		return methodDelivery;
	}
	public void setMethodDelivery(String methodDelivery) {
		this.methodDelivery = methodDelivery;
	}
	public String getOrderStatus() {
		return orderStatus;
	}
	public void setOrderStatus(String orderStatus) {
		this.orderStatus = orderStatus;
	}
	public String getExportBill() {
		return exportBill;
	}
	public void setExportBill(String exportBill) {
		this.exportBill = exportBill;
	}
	
	
}

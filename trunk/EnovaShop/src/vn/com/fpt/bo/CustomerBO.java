package vn.com.fpt.bo;

import vn.com.fpt.dao.CustomerDAO;

public class CustomerBO {

	public void register(String customerAccount, String customerName,
			String gender, String email, String password, String phone,
			String address, String city) {
		// TODO Auto-generated method stub
		CustomerDAO customerDAO = new CustomerDAO();
		customerDAO.register(customerAccount,customerName,gender,email,password,phone,address,city);
	}

}

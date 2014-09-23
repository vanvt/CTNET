/** 
 * AdminBO.java
 * 
 * 1.2
 * 
 * 18/03/2013
 * 
 * Copyright (c) 2013 FPT Software.
 * FPT Building, Street No1, DaNang Industrial Zone, AnDon, 
 * AnHaiBac Ward, SonTra District, DaNang City.
 * All rights reserved.
 */


package vn.com.fpt.bo;

import java.util.ArrayList;
import vn.com.fpt.bean.Products;
import vn.com.fpt.dao.ProductDAO;
import vn.com.fpt.exception.DAOException;


/**
 * Class to implement business logic of module Admin
 * 
 * @author Design Framework Group
 */
public class ProductBO {
	ProductDAO productDAO = new ProductDAO();
	
	public void removeProduct(int ProductId)throws DAOException {
		productDAO.removeProduct(ProductId);
	}
	
	public void updateProduct(Products products)throws DAOException{
		productDAO.updateProduct(products);
	}
	
	public void insertProduct(Products products)throws DAOException {
		productDAO.insertProduct(products);
	}
	
	
	
	public Products selectProductById(int productId) throws DAOException {
		// TODO Auto-generated method stub
		return productDAO.selectProductById(productId);
	}
	
	public Products selectProductByName(String productName) throws DAOException {
		// TODO Auto-generated method stub
		return productDAO.selectProductByName(productName);
	}
	
	public Products selectProductBySKU(String SKU) throws DAOException {
		// TODO Auto-generated method stub
		return productDAO.selectProductBySKU(SKU);
	}
	
	public ArrayList<Products> getListProducts() {
		return productDAO.getListProducts();
	}
}

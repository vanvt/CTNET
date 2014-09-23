package vn.com.fpt.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import vn.com.fpt.bean.Products;
import vn.com.fpt.exception.DAOException;

public class ProductDAO {

	private Connection connection = null;
	private CallableStatement callableStatement = null;
	private ResultSet resultSet = null;
	private CategoryDAO categoryDAO = new CategoryDAO();
	
	public void removeProduct(int productId) throws DAOException {
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call deleteProduct(?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, productId);
			callableStatement.executeUpdate();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
		
	}

	public void updateProduct(Products products) throws DAOException {
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql="{call updateProduct(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, products.getProductId());
			callableStatement.setInt(2, products.getCategory().getCategoryId());
			callableStatement.setString(3, products.getProductName());
			callableStatement.setString(4, products.getSKU());
			callableStatement.setInt(5, products.getQuantity());
			callableStatement.setDouble(6, products.getOriginalPrice());
			callableStatement.setDouble(7, products.getPrice());
			callableStatement.setString(8, products.getDescription());
			callableStatement.setString(9, products.getDetail());
			callableStatement.setString(10, products.getFeature());
			callableStatement.setString(11, products.getReview());
			callableStatement.setString(12, products.getAlias());
			callableStatement.setString(13, products.getPublished());
			callableStatement.setString(14, products.getImageSource());
			callableStatement.execute();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}

	public void insertProduct(Products products) throws DAOException {
		// TODO Auto-generated method stub
		try {
			connection = BaseDAO.getConnection();
			String sql="{call insertProduct(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, products.getProductId());
			callableStatement.setInt(2, products.getCategory().getCategoryId());
			callableStatement.setString(3, products.getProductName());
			callableStatement.setString(4, products.getSKU());
			callableStatement.setInt(5, products.getQuantity());
			callableStatement.setDouble(6, products.getOriginalPrice());
			callableStatement.setDouble(7, products.getPrice());
			callableStatement.setString(8, products.getDescription());
			callableStatement.setString(9, products.getDetail());
			callableStatement.setString(10, products.getFeature());
			callableStatement.setString(11, products.getReview());
			callableStatement.setString(12, products.getAlias());
			callableStatement.setString(13, products.getPublished());
			callableStatement.setString(14, products.getImageSource());
			callableStatement.execute();
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
	}

	public Products selectProductById(int productId) throws DAOException {
		// TODO Auto-generated method stub
		Products products = null;
		try {
			connection = BaseDAO.getConnection();
			String sql="{call selectProductById(?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, productId);
			resultSet = callableStatement.executeQuery();
			
			while (resultSet.next()) {
				products = new Products();
				products.setProductId(resultSet.getInt("ProductId"));
				products.setCategory(categoryDAO.getCategoryById(resultSet.getInt("CategoryId")));
				products.setProductName(resultSet.getString("ProductName"));
				products.setSKU(resultSet.getString("SKU"));
				products.setQuantity(resultSet.getInt("Quantity"));
				products.setOriginalPrice(resultSet.getDouble("OriginalPrice"));
				products.setPrice(resultSet.getDouble("Price"));
				products.setDescription(resultSet.getString("Description"));
				products.setDetail(resultSet.getString("Detail"));
				products.setFeature(resultSet.getString("Feature"));
				products.setReview(resultSet.getString("Review"));
				products.setAlias(resultSet.getString("Alias"));
				products.setPublished(resultSet.getString("Published"));
				products.setImageSource(resultSet.getString("ImageSource"));
				
			}
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (resultSet!=null) resultSet.close();
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
		return products;
	}

	public Products selectProductByName(String productName) throws DAOException {
		// TODO Auto-generated method stub
		Products products = null;
		try {
			connection = BaseDAO.getConnection();
			String sql="{call selectProductByName(?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, productName);
			resultSet = callableStatement.executeQuery();
			
			while (resultSet.next()) {
				products = new Products();
				products.setProductId(resultSet.getInt("ProductId"));
				products.setCategory(categoryDAO.getCategoryById(resultSet.getInt("CategoryId")));
				products.setProductName(resultSet.getString("ProductName"));
				products.setSKU(resultSet.getString("SKU"));
				products.setQuantity(resultSet.getInt("Quantity"));
				products.setOriginalPrice(resultSet.getDouble("OriginalPrice"));
				products.setPrice(resultSet.getDouble("Price"));
				products.setDescription(resultSet.getString("Description"));
				products.setDetail(resultSet.getString("Detail"));
				products.setFeature(resultSet.getString("Feature"));
				products.setReview(resultSet.getString("Review"));
				products.setAlias(resultSet.getString("Alias"));
				products.setPublished(resultSet.getString("Published"));
				products.setImageSource(resultSet.getString("ImageSource"));
				
			}
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (resultSet!=null) resultSet.close();
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
		return products;
	}

	public Products selectProductBySKU(String SKU) throws DAOException {
		// TODO Auto-generated method stub
		Products products = null;
		try {
			connection = BaseDAO.getConnection();
			String sql="{call selectProductBySKU(?)}";
			callableStatement = connection.prepareCall(sql);
			callableStatement.setString(1, SKU);
			resultSet = callableStatement.executeQuery();
			
			while (resultSet.next()) {
				products = new Products();
				products.setProductId(resultSet.getInt("ProductId"));
				products.setCategory(categoryDAO.getCategoryById(resultSet.getInt("CategoryId")));
				products.setProductName(resultSet.getString("ProductName"));
				products.setSKU(resultSet.getString("SKU"));
				products.setQuantity(resultSet.getInt("Quantity"));
				products.setOriginalPrice(resultSet.getDouble("OriginalPrice"));
				products.setPrice(resultSet.getDouble("Price"));
				products.setDescription(resultSet.getString("Description"));
				products.setDetail(resultSet.getString("Detail"));
				products.setFeature(resultSet.getString("Feature"));
				products.setReview(resultSet.getString("Review"));
				products.setAlias(resultSet.getString("Alias"));
				products.setPublished(resultSet.getString("Published"));
				products.setImageSource(resultSet.getString("ImageSource"));
				
			}
		} catch (SQLException e) {
			throw new DAOException(e.getMessage());
		} catch (DAOException e) {
			throw new DAOException(e.getMessage());
		} finally {
			try {
				if (resultSet!=null) resultSet.close();
				if (callableStatement != null)	callableStatement.close();
				if (connection != null)	connection.close();
			} catch (SQLException e) {
				throw new DAOException(e.getMessage());
			}
		}
		return products;
	}

	public ArrayList<Products> getListProducts() {
		// TODO Auto-generated method stub
		ArrayList<Products> list = new ArrayList<Products>();
		Products products = null;
		try {
			connection = BaseDAO.getConnection();
			String sql="{call getListProducts}";
			callableStatement = connection.prepareCall(sql);
			resultSet = callableStatement.executeQuery();
			while (resultSet.next()) {
				products = new Products();
				products.setProductId(resultSet.getInt("ProductId"));
				products.setCategory(categoryDAO.getCategoryById(resultSet.getInt("CategoryId")));
				products.setProductName(resultSet.getString("ProductName"));
				products.setSKU(resultSet.getString("SKU"));
				products.setQuantity(resultSet.getInt("Quantity"));
				products.setOriginalPrice(resultSet.getDouble("OriginalPrice"));
				products.setPrice(resultSet.getDouble("Price"));
				products.setDescription(resultSet.getString("Description"));
				products.setDetail(resultSet.getString("Detail"));
				products.setFeature(resultSet.getString("Feature"));
				products.setReview(resultSet.getString("Review"));
				products.setAlias(resultSet.getString("Alias"));
				products.setPublished(resultSet.getString("Published"));
				products.setImageSource(resultSet.getString("ImageSource"));
				
				list.add(products);
				
			}
		} catch (Exception e) {
			// TODO: handle exception
		}
		return list;
	}
	
	
	
}

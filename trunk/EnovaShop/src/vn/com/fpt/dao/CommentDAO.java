package vn.com.fpt.dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import vn.com.fpt.bean.City;
import vn.com.fpt.bean.Comments;
import vn.com.fpt.exception.DAOException;

public class CommentDAO {
	private Connection connection = null;
	private CallableStatement callableStatement = null;
	private ResultSet resultSet = null;
	private UserDAO userDAO = new UserDAO();
	private ProductDAO productDAO = new ProductDAO();
	/**
	 * Get Comment
	 * @param id
	 * @return
	 * @throws DAOException
	 */
	public Comments getCommentById(int id) throws DAOException {
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call selectCommentById(?)}"; // Call store procedure to add new admin account
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, id);
			resultSet = callableStatement.executeQuery();
			Comments comment = new Comments();
			while(resultSet.next()){
				comment.setCommentId(resultSet.getInt("CommentId"));
				comment.setContent(resultSet.getString("Contents"));
				comment.setTitle(resultSet.getString("Title"));
				comment.setCustomer(userDAO.getUserByUserName(resultSet.getString("CustomerUser")));
				comment.setProductId(resultSet.getInt("ProductID"));
			} 
			return comment;
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
	}
	/**
	 * Get List comment By Product Id
	 * @param productId
	 * @return
	 * @throws DAOException
	 */
	public ArrayList<Comments> getCommentByProductId(int productId) throws DAOException{
		ArrayList<Comments> listComment  = new ArrayList<Comments>();
		try {
			connection = BaseDAO.getConnection();
			String sql = "{call selectCommentByProductId(?)}"; // Call store procedure to add new admin account
			callableStatement = connection.prepareCall(sql);
			callableStatement.setInt(1, productId);
			resultSet = callableStatement.executeQuery();
			
			while(resultSet.next()){
				Comments comment = new Comments();
				comment.setCommentId(resultSet.getInt("CommentId"));
				comment.setContent(resultSet.getString("Contents"));
				comment.setTitle(resultSet.getString("Title"));
				comment.setCustomer(userDAO.getUserByUserName(resultSet.getString("CustomerUser")));
				comment.setProductId(resultSet.getInt("ProductID"));
				listComment.add(comment);
			} 
			return listComment;
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
		
	}
}

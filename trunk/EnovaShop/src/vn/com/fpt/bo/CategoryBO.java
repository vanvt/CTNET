package vn.com.fpt.bo;

import vn.com.fpt.bean.Categories;
import vn.com.fpt.dao.CategoryDAO;
import vn.com.fpt.exception.DAOException;

public class CategoryBO {
	private CategoryDAO categoryDAO = new CategoryDAO();
	/**
	 * Get Category By Id
	 * @param id
	 * @return
	 * @throws DAOException
	 */
	public Categories getCategoryById(int id) throws DAOException{
		return categoryDAO.getCategoryById(id);
	}
	/**
	 * Get Category By Alias
	 * @param alias
	 * @return
	 * @throws DAOException
	 */
	public Categories getCategoryByAlias(String alias) throws DAOException {
		return categoryDAO.getCategoryByAlias(alias);
	}
}

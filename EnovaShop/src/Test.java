import java.util.ArrayList;

import vn.com.fpt.bean.Categories;
import vn.com.fpt.bo.CategoryBO;
import vn.com.fpt.exception.DAOException;


public class Test {
 public static void main(String[] args) throws DAOException {
	 CategoryBO cateBO = new CategoryBO();
	 
	 Categories cate = cateBO.getCategoryByAlias("dien-thoai-may-tinh");
	 ArrayList<Categories> lc = cateBO.getAllCategories();
	 if(lc.size()>0) {
		 for (Categories categories : lc) {
			System.out.println(categories.getCategoryName());
		}
	 }
	 System.out.println(cate.getCategoryName() + " - " + cate.getCategoryAlias() + " - "+cate.getDescription());
}
}

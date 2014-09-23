import vn.com.fpt.bean.Categories;
import vn.com.fpt.bo.CategoryBO;
import vn.com.fpt.exception.DAOException;


public class Test {
 public static void main(String[] args) throws DAOException {
	 CategoryBO cateBO = new CategoryBO();
	 
	 Categories cate = cateBO.getCategoryByAlias("dien-thoai-may-tinh");
	 
	 System.out.println(cate.getCategoryName() + " - " + cate.getCategoryAlias());
}
}

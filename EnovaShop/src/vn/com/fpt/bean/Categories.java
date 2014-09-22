package vn.com.fpt.bean;

public class Categories {
	private int categoryId;
	private String categoryName;
	private String description;
	private int categoryParent;
	private String categoryAlias;
	private String homePublish;
	private int position;
	
	public int getCategoryId() {
		return categoryId;
	}
	public void setCategoryId(int categoryId) {
		this.categoryId = categoryId;
	}
	public String getCategoryName() {
		return categoryName;
	}
	public void setCategoryName(String categoryName) {
		this.categoryName = categoryName;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	
	public int getCategoryParent() {
		return categoryParent;
	}
	public void setCategoryParent(int categoryParent) {
		this.categoryParent = categoryParent;
	}
	public String getCategoryAlias() {
		return categoryAlias;
	}
	public void setCategoryAlias(String categoryAlias) {
		this.categoryAlias = categoryAlias;
	}
	public String getHomePublish() {
		return homePublish;
	}
	public void setHomePublish(String homePublish) {
		this.homePublish = homePublish;
	}
	public int getPosition() {
		return position;
	}
	public void setPosition(int position) {
		this.position = position;
	}
	
	
}

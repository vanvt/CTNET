package vn.com.fpt.bo;

import java.io.File;

public class DeleteCaptchaBO {
	
	public  void deleteCaptcha(String path,int imageIndex,String userName) {
	    try {
	       File file = new File(path+"/", "captcha-"+userName+"-"+imageIndex+".jpg");
	       if (file.delete()) {
	           System.out.println(file.getName() + " is deleted!");
	       } else {
	           System.out.println("Deleteation is failed.");
	       }
	    } catch (Exception e) {
	       e.printStackTrace();
	    }
	 }
}

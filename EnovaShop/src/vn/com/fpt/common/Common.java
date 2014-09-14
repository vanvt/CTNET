/** 
 * Common.java
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


package vn.com.fpt.common;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Properties;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Class to implement common operating methods
 * 
 * @author Design Framework Group
 */
public class Common {

	/*
	 * START - ADD - FRAMEWORK DESIGN TEAM (TRUNGPNN - TRANTTB - VUPT - THUANDT - MYNHH - PHUONGTM) - 15/03/2013
	 */
	/**
	 * Function to check if a string is a valid email
	 * 
	 * @param email : a string email
	 * @return boolean value indicates whether or not the string is a valid
	 *         email
	 */
	public boolean isEmail(String email) {
		String emailPattern = ".+@.+\\.[a-z]+"; // Use Pattern Matching method to validate a email
		Pattern pattern = Pattern.compile(emailPattern);
		Matcher matcher = pattern.matcher(email);
		return matcher.matches();
	}

	/**
	 * Method to encrypt a password
	 * 
	 * @param password : a string express a password
	 * @return a string indicates encrypted value (by MD5) of a password
	 * @throws NoSuchAlgorithmException
	 * @throws UnsupportedEncodingException
	 */
	public String encryptPassword(String password)
	        throws NoSuchAlgorithmException,
	        UnsupportedEncodingException {
		MessageDigest m = MessageDigest.getInstance("MD5"); // Use MessageDisget to encrypt the password string by MD5
		m.update(password.getBytes("UTF-8"));
		byte[] b = m.digest();
		String result = "";
		for (int i = 0; i < b.length; i++) {
			result += Integer.toHexString(
			        (0x000000ff & b[i]) | 0xffffff00).substring(6);
		}
		return result;
	}

	/**
	 * Method to get a property in Resources.properties
	 * 
	 * @param propertyName : a string indicates the name of the property
	 * @return a string express the value of the property
	 * @throws IOException
	 */
	public static String getProperty(String propertyName)
	        throws IOException {
		Properties prop = new Properties(); // Use properties to get property with given name
		prop.load(Common.class
		        .getResourceAsStream("Resources.properties"));
		return prop.getProperty(propertyName);
	}
	/*
	 * END - ADD - FRAMEWORK DESIGN TEAM (TRUNGPNN - TRANTTB - VUPT - THUANDT - MYNHH - PHUONGTM) - 15/03/2013
	 */	
}

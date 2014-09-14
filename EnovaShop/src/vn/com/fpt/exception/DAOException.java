/** 
 * DAOException.java
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


package vn.com.fpt.exception;

/**
 * Class Exception to throw DAO Exceptions
 * 
 * @author Design Framework Group
 */
@SuppressWarnings("serial")
public class DAOException extends Exception {

	/**
	 * Constructor of class
	 * 
	 * @param message: a message express the error
	 */
	public DAOException(String message) {
		super(message);
	}
}

/** 
 * DateValidator.java
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


package vn.com.fpt.admin;

import org.apache.commons.validator.GenericValidator;
import org.apache.commons.validator.ValidatorException;

import vn.com.fpt.common.Constant;

/**
 * Class to validate date values
 * 
 * @author Group Design Framework
 */
public class DateValidator {

	/**
	 * Method to check whether a string is a valid date
	 * 
	 * @param date: string indicates a date
	 * @return boolean value indicates whether or not the string is
	 *         a valid date
	 * @throws ValidatorException
	 */
	public boolean validate(String date) throws ValidatorException {
		Boolean isValid = true;

		/*
		 * If the string is null or blank,
		 * return false with message requiring choosing the date
		 */
		if (GenericValidator.isBlankOrNull(date)) {
			isValid = false;
			throw new ValidatorException("Date must be choosen!");
		}
		
		/*
		 * If the string is not a valid date,
		 * return false with inform message
		 */
		if (!GenericValidator.isDate(date, Constant.DATE_FORMAT, false)) {
			isValid = false;
			throw new ValidatorException("Date is invalid!");
		}
		
		return isValid;
	}
}
/** 
 * TextFieldValidator.java
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
 * Class to validate text fields
 * 
 * @author Group Design Framework
 */
public class TextFieldValidator {

	/**
	 * Method to check whether a text field is valid
	 * 
	 * @param text: string indicates a text
	 * @return boolean value indicate whether or not a text field is valid
	 * @throws ValidatorException
	 */
	public boolean validate(String text) throws ValidatorException {
		Boolean isValid = true;

		/*
		 * If the string is null or blank,
		 * return false with an inform message
		 */
		if (GenericValidator.isBlankOrNull(text)) {
			isValid = false;
			throw new ValidatorException("Empty String is not allowed!");
		}
		
		/*
		 * If the string is larger than 15 characters,
		 * return false with an inform message
		 */
		if (!GenericValidator.maxLength(text, Constant.MAX_LENGTH_OF_TEXT_FIELD)) {
			isValid = false;
			throw new ValidatorException(
			        "The length of string cannot be greater than " 
			        		+ Constant.MAX_LENGTH_OF_TEXT_FIELD + "!");
		}
		
		/*
		 * If the string is less than 3 characters,
		 * return false with an inform message
		 */
		if (!GenericValidator.minLength(text, Constant.MIN_LENGTH_OF_TEXT_FIELD)) {
			isValid = false;
			throw new ValidatorException(
			        "The length of string cannot be fewer than " 
			        		+ Constant.MIN_LENGTH_OF_TEXT_FIELD + "!");
		}
		return isValid;
	}
}
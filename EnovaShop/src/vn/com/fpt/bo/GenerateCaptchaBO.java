package vn.com.fpt.bo;


import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics2D;
import java.awt.GraphicsEnvironment;
import java.awt.geom.Rectangle2D;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.Random;

import javax.imageio.ImageIO;

public class GenerateCaptchaBO {
	static boolean isInvalidIndexFont(int index, int listIndex[]) {

		for (int i : listIndex) {
			if (i == index) {
				return true;
			}
		}
		return false;
	}

	public static String getImageCode(int totalChars) {
		String StringValid = "2345678qwertyupasdfhkzxcvbnm";
		Random ran = new Random();
		StringBuffer stringbuffer = new StringBuffer();

		for (int i = 0; i < totalChars; i++) {
			int index = ran.nextInt(StringValid.length());
			stringbuffer.append(StringValid.substring(index, index + 1));
		}
		String imacode = stringbuffer.toString();
	
		return imacode;
	}
	public String generationCaptcha(String path,int imageIndex,String userName){
		int iTotalChars = 6;
		int invalidindex[] = { 209, 278, 141, 301, 266, 275, 299, 290, 302,304,
				210, 207, 212, 213, 249, 303, 203, 123, 43, 174, 158, 155,276,204, 267,164,258,279,291};
		/*
		 * Size image iHeight and iWidth, declare globl
		 */
		int iHeight = 50;
		int iWidth = 150;
		// Good Font : 172,90,279,241
		/*
		 * font style
		 */
		GraphicsEnvironment e = GraphicsEnvironment
				.getLocalGraphicsEnvironment();
		Font[] fonts = e.getAllFonts();

		/*
		 * Possible random characters in the image
		 */
		Random randChars = new Random();

		String sImageCode = getImageCode(iTotalChars);

	
		/*
		 * BufferedImage is used to create a create new image
		 */
		/*
		 * TYPE_INT_RGB - does not support transpatency, TYPE_INT_ARGB - support
		 * transpatency
		 */
		BufferedImage biImage = new BufferedImage(iWidth, iHeight,
				BufferedImage.TYPE_INT_RGB);
		Graphics2D g2dImage = (Graphics2D) biImage.getGraphics();

		// Draw background rectangle and noisey filled round rectangles
		//int iCircle = 25;

		
		Rectangle2D.Double rectangle2 = new Rectangle2D.Double(1, 1,
				iWidth - 2, iHeight - 2);
		g2dImage.setColor(Color.CYAN);
		g2dImage.fill(rectangle2);
		// g2dImage.setColor(new Color(randChars.nextInt(255), randChars
		// .nextInt(255), randChars.nextInt(255)));
		g2dImage.fillRoundRect(0, 0, 1000, 1000, 1000, 1000);
		// g2dImage.setBackground(new Color(randChars.nextInt(255),
		// randChars.nextInt(255), randChars.nextInt(255)));
		g2dImage.setColor(Color.black);

		// g2dImage.setColor(Color.green);
		// for (int i = 2; i < iHeight-2; i++) {
		//
		// g2dImage.drawLine(0, i, iWidth, i);
		// }
		int indexRedColor =randChars.nextInt(30);
		int indexGreenColor= randChars.nextInt(30);
		int indexBlueColor =randChars.nextInt(30);
		for (int i = 0; i < iWidth; i = i+1) {
			g2dImage.setColor(new Color(indexRedColor + (i), indexGreenColor + (i), indexBlueColor + (i)));
			g2dImage.drawLine(i, 0, i, iHeight);
		}
		
		
//		for (int i = 0; i < iCircle; i++) {
//			g2dImage.setColor(new Color(randChars.nextInt(30), randChars
//					.nextInt(30), randChars.nextInt(30)));
//			int iRadius = (int) (Math.random() * iHeight / 2.0);
//			int iX = (int) (Math.random() * iWidth - iRadius);
//			int iY = (int) (Math.random() * iHeight - iRadius);
//			Ellipse2D.Double circle = new Ellipse2D.Double(iX, iY,
//					randChars.nextInt(50), iRadius * 2);
//			Rectangle2D.Double rectangle = new Rectangle2D.Double(0, 0, iWidth,
//					iHeight);
//			//g2dImage.draw(circle);
//			 g2dImage.fillRoundRect(iX, iY, iRadius * 2, iRadius * 2, 100,
//			 100);
//		}

		
		for (int i = 0; i < iTotalChars; i++) {
			g2dImage.setColor(new Color(150+randChars.nextInt(105),150+ randChars
					.nextInt(105), 150+randChars.nextInt(105)));
			int fontindex = 0;
			while (true) {
				int tmpindex = randChars.nextInt(fonts.length);
				if (isInvalidIndexFont(tmpindex, invalidindex)) {
					// do not thing
				} else {
					fontindex = tmpindex;
					break;
				}
			}
			System.out.print(userName+": "+fontindex+"captcha thu "+imageIndex+"  ");
			Font fntStyle1 = new Font(fonts[fontindex].getFontName(),
					Font.BOLD, 40);
			g2dImage.setFont(fntStyle1);
			g2dImage.drawString(sImageCode.substring(i, i + 1),
					(randChars.nextInt(3) + 22) * i, randChars.nextInt(16) + 25);

			
		}
		System.out.println(path);
		System.out.println("---------------------------------");
		g2dImage.setColor(Color.BLACK);
		Rectangle2D.Double rectangle = new Rectangle2D.Double(0, 0, iWidth - 1,
				iHeight - 1);
		g2dImage.draw(rectangle);
		
		/*
		 * create jpeg image and display on the screen
		 */

	
		try {
			ImageIO.write(biImage, "jpg", new File(path+"/", "captcha-"+userName+"-"+imageIndex+".jpg"));
		} catch (IOException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		
		
		// osImage.close();

		/*
		 * Dispose function is used destory an image object
		 */
		g2dImage.dispose();
		return sImageCode;
		
		// System.out.println("Captcha Page :"+session.getAttribute("dns_security_code"));

	}
}


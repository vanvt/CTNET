
import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import nl.captcha.Captcha;

/**
 * Servlet implementation class CheckCapCha
 */
public class CheckCapCha extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public CheckCapCha() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doPost(request, response);

	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		HttpSession session = request.getSession();

		Captcha capcha = (Captcha) session.getAttribute(Captcha.NAME);
		String answer = request.getParameter("capcha");
		
	if(capcha.getAnswer().equals(answer)){
			response.sendRedirect("ok.jsp");
	}else{
		response.sendRedirect("fail.jsp");
		}
	System.out.println(answer);
	System.out.println(capcha.getAnswer());
	System.out.println(Captcha.NAME);
	}
}

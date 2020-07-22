package DefaultPackage;

import java.util.Scanner;

public class App {

	public static void main(String [] args) {
		String q1 = "What is Hibernate?\n"
				+ "(a)Hibernate ORM (or simply Hibernate) is an object-relational mapping tool for the Java programming language. It provides a framework for mapping an object-oriented domain model to a relational database. ... It generates SQL calls and relieves the developer from the manual handling and object conversion of the result set.\n{b)As a relative newcomer to the programming world, terms like Object-Relational-Mapper can sound really intimidating. \n(C)The technique to convert data between object model and relational database is known as object-relational mapping\n";
		String q2 = "What is a Java collections?\n"
				+ "(a)a collection that cannot contain duplicate elements\n(b)A unified architecture for representing and manipulating collections\r\n" + 
				"Contain:\r\n" + 
				"Interfaces-ADTs that represent collections\r\n" + 
				"Implementations-concrete implementations of the collection interfaces\r\n" + 
				"Algorithms-methods that perform useful computations on objects that implement collection interfaces\n(c)implements the List interface\r\n" + 
				"Doubly-linked list implementation of the List and Deque interfaces.\n";
		String q3 = "What is Jackson JSON?\n"
				+ "(a)Is a lightweight data-interchange format\r\n" + "(b)Is a web server\r\n" +
				"(c)Cookies?\n";
		String q4 = "What is HTTP?\n"
				+ "(a)The HTTP/URL is an object used by a servlet to track a user's interaction with a Web application across multiple HTTP requests\r\n" + 
				"(b)The servlet mapping defines an association between a URL pattern and a servlet. The mapping is used to map requests to Servlets\r\n" +
				"(c)Hypertext Transfer Protocol\r\n" + 
				"Protocol - A standard procedure for defining and regulating communication\r\n" + 
				"Request-response protocol that web servers and their clients use to communicate\r\n";
		String q5 = "What is JUnit?\n"
				+ "(a)Small piece of data sent by the server that resides in client browser\r\n" + 
				"(b)Allows state, so when you want to remember a user or a users information\r\n" +
				"(c)Is a testing framework for Java\r\n";
		String q6 = "What is a Use Case Document?\n"
				+ "(a)Is a schema-less, text-based representation of structured data that is based on key-value pairs and ordered lists\r\n" +
				"(b)Is a business document which provides a story of how a system, and its actors, will be utilized to achieve a specific goal. An effective Use Case should provide a detailed step-by-step description of how the system will be used by its actors to achieve the planned outcome\r\n" +
				"(c)Unit is a unit testing framework for Java programming language\r\n";
		String q7 = "What is UML Sequence?\n"
				+ "(a)An “interaction diagram” that models a single scenario executing in a system\r\n" + 
				"(b)Is a Java programming language class that is used to extend the capabilities of servers that host applications accessed by means of a request-response programming model\r\n" +
				"(c)Is an object-relational mapping tool for the Java programming language\r\n" + "(d)None of the Above\r\n";
		String q8 = "What is Servlets?\n"
				+ "(a)Is open source testing framework developed for unit testing java code and is now the default framework for testing Java development\n" +
				"(b)Is a Java programming language class that is used to extend the capabilities of servers that host applications accessed by means of a request-response programming model\r\n" +
				"(c)a & b\r\n" + "(d)None of the Above\r\n";
	Question [] questions = {
			
			
			new Question(q1, "a"),
			new Question(q2, "b"),
			new Question(q3, "a"),
			new Question(q4, "c"),
			new Question(q5, "c"),
			new Question(q6, "b"),
			new Question(q7, "a"),
			new Question(q8, "b")
	};
	takeTest(questions);
	
	}
public static void takeTest(Question [] questions) {
	int score = 0;
	Scanner keyboardInput = new Scanner(System.in);
	
	for(int i = 0; i < questions.length; i++) {
		System.out.println(questions[i].prompt);
		String answer = keyboardInput.nextLine();
		if(answer.equals(questions[i].answer)) {
			score++;
		}
		}
		System.out.println("You got " + score + "/" + questions.length);
	}
	}




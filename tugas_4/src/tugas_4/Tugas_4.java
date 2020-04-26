/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tugas_4;

/**
 *
 * @author Nillasanti Puspita N
 */
public class Tugas_4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Instructor instr = new Instructor("Muhammad", "Naufal", "NFL195");
	    TextBook book = new TextBook("This Book Loves You", "Felix", "Kjellberg");
	    Course course = new Course("How to be 9 years Old", instr, book);

	    System.out.println(course.toString());
    }
    
}

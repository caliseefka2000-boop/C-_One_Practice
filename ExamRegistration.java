import java.util.Scanner;

class InvalidRegistrationException extends Exception {
    public InvalidRegistrationException(String message) {
        super(message);
    }
}

public class ExamRegistration {
    
    public static void validateRegistration(String studentId, String name, int age, double mark, int subjects) throws InvalidRegistrationException {
        if (studentId == null || studentId.trim().isEmpty()) {
            throw new InvalidRegistrationException("Student ID cannot be empty.");
        }
        if (age < 18) {
            throw new InvalidRegistrationException("Age must be at least 18.");
        }
        if (mark < 0 || mark > 100) {
            throw new InvalidRegistrationException("Examination mark must be between 0 and 100.");
        }
        if (subjects < 1 || subjects > 5) {
            throw new InvalidRegistrationException("Maximum allowed subjects is 5.");
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("===== EXAM REGISTRATION SYSTEM =====");

        try {
            System.out.print("Enter Student ID: ");
            String studentId = scanner.nextLine();

            System.out.print("Enter Student Name: ");
            String name = scanner.nextLine();

            System.out.print("Enter Age: ");
            int age = scanner.nextInt();

            System.out.print("Enter Exam Mark: ");
            double mark = scanner.nextDouble();

            System.out.print("Enter Number of Subjects: ");
            int subjects = scanner.nextInt();

            validateRegistration(studentId, name, age, mark, subjects);

            System.out.println("\nRegistration Successful!");
            System.out.println("Student: " + name);
            System.out.println("Registered Subjects: " + subjects);

        } catch (InvalidRegistrationException e) {
            System.out.println("\nRegistration Failed!");
            System.out.println("Error: " + e.getMessage());
        } catch (Exception e) {
            System.out.println("\nRegistration Failed!");
            System.out.println("Error: Invalid input format.");
        } finally {
            System.out.println("\nRegistration attempt completed.");
            scanner.close();
        }
    }
}

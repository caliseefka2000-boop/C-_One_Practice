// Superclass: Patient
class Patient {
    protected String name;
    protected double consultFee;

    public Patient(String name, double consultFee) {
        this.name = name;
        this.consultFee = consultFee;
    }

    public void Display() {
        System.out.println("Patient Name: " + name);
        System.out.println("Consultation Fee: $" + consultFee);
    }
}

// Subclass One: Outpatient
class Outpatient extends Patient {
    private double labCharge;

    public Outpatient(String name, double consultFee, double labCharge) {
        super(name, consultFee);
        this.labCharge = labCharge;
    }

    public double CalculateBill() {
        return labCharge + consultFee;
    }

    @Override
    public void Display() {
        super.Display();
        System.out.println("Lab Charge: $" + labCharge);
        System.out.println("Total Bill: $" + CalculateBill());
    }
}

// Subclass Two: Inpatient
class Inpatient extends Patient {
    private double roomCharge;
    private int numberOfDays;

    public Inpatient(String name, double consultFee, double roomCharge, int numberOfDays) {
        super(name, consultFee);
        this.roomCharge = roomCharge;
        this.numberOfDays = numberOfDays;
    }

    public double CalculateBill() {
        return (numberOfDays * roomCharge) + consultFee;
    }

    @Override
    public void Display() {
        super.Display();
        System.out.println("Room Charge per Day: $" + roomCharge);
        System.out.println("Number of Days: " + numberOfDays);
        System.out.println("Total Bill: $" + CalculateBill());
    }
}

// Main Test Class
public class HospitalTest {
    public static void main(String[] args) {
        System.out.println("=== Outpatient Record ===");
        Outpatient op = new Outpatient("Ahmed Ali", 50.0, 30.0);
        op.Display();

        System.out.println("\n=== Inpatient Record ===");
        Inpatient ip = new Inpatient("Fatima Omar", 100.0, 150.0, 4);
        ip.Display();
    }
}

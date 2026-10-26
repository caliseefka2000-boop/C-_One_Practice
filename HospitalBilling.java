abstract class MedicalService {
    protected String serviceId;
    protected String serviceName;
    protected double baseCost;

    public MedicalService(String serviceId, String serviceName, double baseCost) {
        this.serviceId = serviceId;
        this.serviceName = serviceName;
        this.baseCost = baseCost;
    }

    public abstract double calculateTotalCost();

    public void displayServiceInfo() {
        System.out.println("Service ID: " + serviceId);
        System.out.println("Service: " + serviceName);
        System.out.println("Total Cost: $" + String.format("%.2f", calculateTotalCost()));
        System.out.println();
    }
}

class Consultation extends MedicalService {
    private double doctorFee;

    public Consultation(String serviceId, String serviceName, double baseCost, double doctorFee) {
        super(serviceId, serviceName, baseCost);
        this.doctorFee = doctorFee;
    }

    @Override
    public double calculateTotalCost() {
        return baseCost + doctorFee;
    }
}

class LaboratoryTest extends MedicalService {
    private double testCharge;

    public LaboratoryTest(String serviceId, String serviceName, double baseCost, double testCharge) {
        super(serviceId, serviceName, baseCost);
        this.testCharge = testCharge;
    }

    @Override
    public double calculateTotalCost() {
        return baseCost + testCharge;
    }
}

class Ultrasound extends MedicalService {
    private double additionalFee;

    public Ultrasound(String serviceId, String serviceName, double baseCost, double additionalFee) {
        super(serviceId, serviceName, baseCost);
        this.additionalFee = additionalFee;
    }

    @Override
    public double calculateTotalCost() {
        return baseCost + additionalFee;
    }
}

public class HospitalBilling {
    public static void main(String[] args) {
        MedicalService[] services = {
            new Consultation("S001", "Consultation", 15.0, 10.0),
            new LaboratoryTest("S002", "Laboratory Test", 10.0, 8.0),
            new Ultrasound("S003", "Ultrasound", 25.0, 15.0)
        };

        System.out.println("===== HOSPITAL BILLING SYSTEM =====");
        System.out.println();

        double totalHospitalBill = 0.0;
        for (MedicalService service : services) {
            service.displayServiceInfo();
            totalHospitalBill += service.calculateTotalCost();
        }

        System.out.println("--------------------");
        System.out.println("Total Hospital Bill: $" + String.format("%.2f", totalHospitalBill));
    }
}

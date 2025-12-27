using System;

namespace Healthcare;

public class Billing
{
   public static PatientBill LastBill;
   public static bool HasLastBill=false;

   //Create Register Bill
   public static void CreateNewBill(){
   PatientBill bill=new PatientBill();

   Console.WriteLine("Enter Bill Id: ");
   bill.BillId=Console.ReadLine();
   if (string.IsNullOrWhiteSpace(bill.BillId))
    {
        Console.WriteLine("Bill Id cannot be empty.");
        return;
    }

   System.Console.WriteLine("Enter Patient Name: ");
   bill.PatientName=Console.ReadLine();

   System.Console.WriteLine("Is the Patient insured?(Y/N): ");
   char choice = char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine();

    bill.HasInsurance = (choice == 'Y');

    Console.Write("Enter Consultation Fee: ");
    bill.ConsultationFee = decimal.Parse(Console.ReadLine());
        if (bill.ConsultationFee <= 0)
        {
            System.Console.WriteLine("Consultation fee must be greater than Zero!");
            return;
        }

    System.Console.WriteLine("Enter Lab Charges: ");
    bill.LabCharges=decimal.Parse(Console.ReadLine());

    System.Console.WriteLine("Enter Medicine Charges: ");
    bill.MedicineCharges=decimal.Parse(Console.ReadLine());

    if(bill.LabCharges<0 || bill.MedicineCharges < 0)
        {
            System.Console.WriteLine("Charges Can't be Negative");
            return;
        }

//Billing Rules & Calculation

bill.GrossAmount=bill.ConsultationFee+
     bill.LabCharges+
     bill.MedicineCharges;

        if (bill.HasInsurance)
        {
            bill.DiscountAmount=bill.GrossAmount*0.10m;

        }
        else
        {
            bill.DiscountAmount=0;
        }
        bill.FinalPayable=bill.GrossAmount-bill.DiscountAmount;
        // Store statically
            LastBill = bill;
            HasLastBill = true;

            Console.WriteLine("\nBill created successfully.");
            Console.WriteLine("Gross Amount: " + bill.GrossAmount.ToString("F2"));
            Console.WriteLine("Discount Amount: " + bill.DiscountAmount.ToString("F2"));
            Console.WriteLine("Final Payable: " + bill.FinalPayable.ToString("F2"));
            Console.WriteLine("------------------------------------------------------------");
        }

    //View LastBill
    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }
        Console.WriteLine("\n----------- Last Bill -----------");
            Console.WriteLine("BillId: " + LastBill.BillId);
            Console.WriteLine("Patient: " + LastBill.PatientName);
            Console.WriteLine("Insured: " + (LastBill.HasInsurance ? "Yes" : "No"));
            Console.WriteLine("Consultation Fee: " + LastBill.ConsultationFee.ToString("F2"));
            Console.WriteLine("Lab Charges: " + LastBill.LabCharges.ToString("F2"));
            Console.WriteLine("Medicine Charges: " + LastBill.MedicineCharges.ToString("F2"));
            Console.WriteLine("Gross Amount: " + LastBill.GrossAmount.ToString("F2"));
            Console.WriteLine("Discount Amount: " + LastBill.DiscountAmount.ToString("F2"));
            Console.WriteLine("Final Payable: " + LastBill.FinalPayable.ToString("F2"));
            Console.WriteLine("--------------------------------");
            System.Console.WriteLine("------------------------------------------");
       
    }

//clear the lastBill
public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
        }
}

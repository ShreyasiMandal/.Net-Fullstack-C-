using System;
using SmartBankSystem;
/*
SmartBank – Customer Credit Risk Evaluation System

Problem Statement:
Develop a banking system that evaluates customer financial stability
and determines the maximum credit limit.

The system must:
1. Accept customer details:
   - Customer Name
   - Age
   - Employment Type
   - Monthly Income
   - Existing Credit Card Dues
   - Credit Score
   - Number of Loan Defaults

2. Validate inputs using CreditRiskProcessor class.
   Throw InvalidCreditDataException if:

   - Age not between 21 and 65 → "Invalid age"
   - Employment Type not "Salaried" or "Self-Employed"
     → "Invalid employment type"
   - Monthly Income < 20000 → "Invalid monthly income"
   - Dues < 0 → "Invalid credit dues"
   - Credit Score not between 300 and 900
     → "Invalid credit score"
   - Defaults < 0 → "Invalid default count"

3. Calculate Debt Ratio:
   Debt Ratio = Dues / (Monthly Income * 12)

4. Determine Risk Category:

   High Risk:
   - Credit Score < 600
   - OR Defaults >= 3
   - OR Debt Ratio > 0.4
   → Credit Limit = ₹50,000

   Medium Risk:
   - Credit Score between 600 and 749
   - OR Defaults = 1 or 2
   → Credit Limit = ₹1,50,000

   Low Risk:
   - Credit Score >= 750
   - AND Defaults = 0
   - AND Debt Ratio < 0.25
   → Credit Limit = ₹3,00,000

5. If validation passes:
   Display Customer Name and Approved Credit Limit.

6. If validation fails:
   Display only the exception message.
*/

public class CreditRiskProcessor
{
    int age;
    string employmentType;
    double monthlyIncome;
    double dues;
    int creditScore;
    int defaults;

    public CreditRiskProcessor(int age,string employmentType,double monthlyIncome,double dues,int creditScore,int defaults)
    {
        this.age=age;
        this.employmentType=employmentType;
        this.monthlyIncome=monthlyIncome;
        this.dues=dues;
        this.creditScore=creditScore;
        this.defaults=defaults;     
    }

    public bool ValidateEmployeeDetails()
    {
        // - Age not between 21 and 65 → "Invalid age"
//    - Employment Type not "Salaried" or "Self-Employed"
//      → "Invalid employment type"
//    - Monthly Income < 20000 → "Invalid monthly income"
//    - Dues < 0 → "Invalid credit dues"
//    - Credit Score not between 300 and 900
//      → "Invalid credit score"
//    - Defaults < 0 → "Invalid default count"
        if(age<21 || age > 65)
        {
            throw new InvalidCreditDataException("Invalid Age");
        }
        if(employmentType!="Salaried" && employmentType != "Self-Employed")
        {
            throw new InvalidCreditDataException("Invalid Employee Type");
        }
        if (monthlyIncome < 20000)
        {
            throw new InvalidCreditDataException("Invalid Monthly Income");
        }
        if (dues < 0)
        {
            throw new InvalidCreditDataException("Invalid Credit dues"); 
        }
        if(creditScore<300 || creditScore > 900)
        {
            throw new InvalidCreditDataException("Invalid Credit Score");
        }
        if (defaults < 0)
        {
            throw new InvalidCreditDataException("Invalid Default Count");
        }

        return true;
    }
//     4. Determine Risk Category:

//    High Risk:
//    - Credit Score < 600
//    - OR Defaults >= 3
//    - OR Debt Ratio > 0.4
//    → Credit Limit = ₹50,000

//    Medium Risk:
//    - Credit Score between 600 and 749
//    - OR Defaults = 1 or 2
//    → Credit Limit = ₹1,50,000

//    Low Risk:
//    - Credit Score >= 750
//    - AND Defaults = 0
//    - AND Debt Ratio < 0.25
//    → Credit Limit = ₹3,00,000
//3. Calculate Debt Ratio:
//    Debt Ratio = Dues / (Monthly Income * 12)
public double CralculateCreditLimits()
    {
        double debtRatio=dues / (monthlyIncome * 12);
        if(creditScore<600 || defaults>=3 || debtRatio > 0.4)
        {
            return 50000;
        }
         if(creditScore>=600  && creditScore<=749 || defaults==1 || defaults==2 )
        {
            return 150000;
        }
         if(creditScore>750 && defaults==0 && debtRatio <0.25)
        {
            return 300000;
        }

        return 50000;
    }

}
using System;

namespace MultiTenantReportGenerator;

public class TenantReport
{
 public string TenantId { get; set; }
public double TotalCredits { get; set; }
public double TotalDebits { get; set; }
public int PeakTransactionHour { get; set; }
public bool IsSuspicious { get; set; }
}

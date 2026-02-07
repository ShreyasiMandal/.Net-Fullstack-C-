using System;

namespace MultiTenantReportGenerator;

public class ReportGenerator
{
     public static List<TenantReport> GenerateReports(List<Transaction> transactions)
    {
        List<TenantReport> reports = new List<TenantReport>();

        var groupedByTenant = transactions.GroupBy(t => t.TenantId);

        foreach (var tenantGroup in groupedByTenant)
        {
            TenantReport report = new TenantReport();
            report.TenantId = tenantGroup.Key;

            // Total credits & debits
            report.TotalCredits = tenantGroup
                .Where(t => t.Type.Equals("Credit", StringComparison.OrdinalIgnoreCase))
                .Sum(t => t.Amount);

            report.TotalDebits = tenantGroup
                .Where(t => t.Type.Equals("Debit", StringComparison.OrdinalIgnoreCase))
                .Sum(t => t.Amount);

            // Peak transaction hour
            report.PeakTransactionHour = tenantGroup
                .GroupBy(t => t.Timestamp.Hour)
                .OrderByDescending(g => g.Count())
                .First().Key;

            // Suspicious rule: >3 debits within 5 minutes
            var debitTxns = tenantGroup
                .Where(t => t.Type.Equals("Debit", StringComparison.OrdinalIgnoreCase))
                .OrderBy(t => t.Timestamp)
                .ToList();

            report.IsSuspicious = false;

            for (int i = 0; i < debitTxns.Count; i++)
            {
                var window = debitTxns
                    .Where(t =>
                        t.Timestamp >= debitTxns[i].Timestamp &&
                        t.Timestamp <= debitTxns[i].Timestamp.AddMinutes(5))
                    .ToList();

                if (window.Count > 3)
                {
                    report.IsSuspicious = true;
                    break;
                }
            }

            reports.Add(report);
        }

        return reports;
}
}

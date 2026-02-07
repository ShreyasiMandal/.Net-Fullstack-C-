using System;
using System.Collections.Generic;
using System.Linq;
namespace FraudTransaction;

public class FraudDetector
{
    public static List<FraudAlert> DetectFraud(List<Transaction> txns)
    {
        List<FraudAlert> alerts = new List<FraudAlert>();

        // Group transactions by card
        var groupedByCard = txns.GroupBy(t => t.CardNumber);

        foreach (var cardGroup in groupedByCard)
        {
            var orderedTxns = cardGroup.OrderBy(t => t.Time).ToList();

            // RULE 1: 3+ transactions > 50,000 within 2 minutes
            for (int i = 0; i < orderedTxns.Count; i++)
            {
                var window = orderedTxns
                    .Where(t =>
                        t.Time >= orderedTxns[i].Time &&
                        t.Time <= orderedTxns[i].Time.AddMinutes(2) &&
                        t.Amount > 50000)
                    .ToList();

                if (window.Count >= 3)
                {
                    alerts.Add(new FraudAlert(
                        cardGroup.Key,
                        "3+ high value transactions within 2 minutes"
                    ));
                    break;
                }
            }

            // RULE 2: Same card used in 2 cities within 10 minutes
            for (int i = 0; i < orderedTxns.Count - 1; i++)
            {
                for (int j = i + 1; j < orderedTxns.Count; j++)
                {
                    if (orderedTxns[j].Time > orderedTxns[i].Time.AddMinutes(10))
                        break;

                    if (orderedTxns[i].City != orderedTxns[j].City)
                    {
                        alerts.Add(new FraudAlert(
                            cardGroup.Key,
                            "Same card used in multiple cities within 10 minutes"
                        ));
                        goto NEXT_CARD; // stop checking this card further
                    }
                }
            }

        NEXT_CARD:;
        }

        return alerts;
    }
}

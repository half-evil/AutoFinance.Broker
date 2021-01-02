// Licensed under the Apache License, Version 2.0.

namespace AutoFinance.Broker.InteractiveBrokers.EventArgs
{
    using IBApi;

    /// <summary>
    /// The event arguments when portfolio is updated
    /// </summary>
    public class UpdatePortfolioEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePortfolioEventArgs"/> class.
        /// </summary>
        /// <param name="contract">Contract.</param>
        /// <param name="position">The position.</param>
        /// <param name="marketPrice">The market price.</param>
        /// <param name="marketValue">The market value.</param>
        /// <param name="averageCost">The average cost.</param>
        /// <param name="unrealizedPNL">The unrealized PNL.</param>
        /// <param name="realizedPNL">The realized PNL.</param>
        /// <param name="accountName">The account name.</param>
        public UpdatePortfolioEventArgs(
            Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
       {
           this.Contract = contract;
           this.Position = position;
           this.MarketPrice = marketPrice;
           this.MarketValue = marketValue;
           this.AverageCost = averageCost;
           this.AccountName = accountName;
           this.UnrealizedPNL = unrealizedPNL;
           this.RealizedPNL = realizedPNL;
       }

        /// <summary>
        /// Gets the request id.
        /// </summary>
        public Contract Contract { get; private set; }

        /// <summary>
        /// Gets the position
        /// </summary>
        public double Position { get; private set; }

        /// <summary>
        /// Gets the market price
        /// </summary>
        public double MarketPrice { get; private set; }

        /// <summary>
        /// Gets the market value
        /// </summary>
        public double MarketValue { get; private set; }

        /// <summary>
        /// Gets the avarage cost
        /// </summary>
        public double AverageCost { get; private set; }

        /// <summary>
        /// Gets the unrealized profit and loss
        /// </summary>
        public double UnrealizedPNL { get; private set; }

        /// <summary>
        /// Gets the realized profit and loss
        /// </summary>
        public double RealizedPNL { get; private set; }

        /// <summary>
        /// Gets the account name
        /// </summary>
        public string AccountName { get; private set; }
    }
}

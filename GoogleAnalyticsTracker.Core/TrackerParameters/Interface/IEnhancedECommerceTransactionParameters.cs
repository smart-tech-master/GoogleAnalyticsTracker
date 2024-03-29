﻿using JetBrains.Annotations;

namespace GoogleAnalyticsTracker.Core.TrackerParameters.Interface;

[PublicAPI]
public interface IEnhancedECommerceTransactionParameters : IECommerceTransactionParameters, IProvideProductsParameters
{
    /// <summary>
    /// Specifies the transaction coupon redeemed with the transaction.
    /// <remarks>Optional. Can be sent when Product Action is set to 'purchase' or 'refund'.</remarks>
    /// <example>SUMMER08</example>
    /// </summary> 
    string? CouponCode { get; set; }

    /// <summary>
    /// Specifies the list or collection from which a product action occurred.
    /// <remarks>Optional. Can be sent when Product Action is set to 'detail' or 'click'.</remarks>
    /// <example>Search Results</example>
    /// </summary> 
    string? ProductActionList { get; set; }

    /// <summary>
    /// Specifies the list or collection from which a product action occurred.
    /// <remarks>Optional. Can be sent when Product Action is set to 'detail' or 'click'.</remarks>
    /// <example>2</example>
    /// </summary>
    int? CheckoutStep { get; set; }

    /// <summary>
    /// Additional information about a checkout step.
    /// <remarks>Optional. Can be sent when Product Action is set to 'checkout'.</remarks>
    /// <example>Visa</example>
    /// </summary>
    string? CheckoutStepOption { get; set; }
}
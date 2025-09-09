using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentFundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentFundInfo : AopObject
    {
        /// <summary>
        /// 收款方资产信息
        /// </summary>
        [XmlElement("payee_asset_info")]
        public PaymentAssetInfo PayeeAssetInfo { get; set; }

        /// <summary>
        /// 付款方资产信息
        /// </summary>
        [XmlElement("payer_asset_info")]
        public PaymentAssetInfo PayerAssetInfo { get; set; }
    }
}

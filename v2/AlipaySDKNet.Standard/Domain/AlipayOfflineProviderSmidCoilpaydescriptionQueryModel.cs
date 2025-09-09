using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderSmidCoilpaydescriptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderSmidCoilpaydescriptionQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝间连商家smid
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}

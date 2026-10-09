using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductInviteStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductInviteStatusInfo : AopObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// NONE：未签约，表示还没有签约该产品 MERCHANT_AUDITING：审核中，已经有合约在审核中，请等待审核完成 MERCHANT_CONFIRM_SUCCESS：已生效，表示合约已经生效，不需要再签约了 MERCHANT_APPLY_ORDER_CANCELED：审核未通过
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

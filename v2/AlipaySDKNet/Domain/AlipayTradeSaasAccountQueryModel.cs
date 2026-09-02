using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasAccountQueryModel : AopObject
    {
        /// <summary>
        /// SaaS客户ID。与out_merchant_no至少传入一个；两个字段同时传入时必须指向同一客户。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 外部平台为二级商户分配的唯一编码。与customer_id至少传入一个；两个字段同时传入时必须指向同一客户。
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }
    }
}

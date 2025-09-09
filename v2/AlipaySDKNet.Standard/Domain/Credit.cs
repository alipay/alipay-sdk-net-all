using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Credit Data Structure.
    /// </summary>
    [Serializable]
    public class Credit : AopObject
    {
        /// <summary>
        /// 客户授信金额，单位分
        /// </summary>
        [XmlElement("credit_amt")]
        public long CreditAmt { get; set; }

        /// <summary>
        /// 定价列表
        /// </summary>
        [XmlArray("credit_pricing_list")]
        [XmlArrayItem("credit_pricing")]
        public List<CreditPricing> CreditPricingList { get; set; }

        /// <summary>
        /// 是否默认授信
        /// </summary>
        [XmlElement("default_credit")]
        public bool DefaultCredit { get; set; }

        /// <summary>
        /// 授信过期时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 贷款类型
        /// </summary>
        [XmlElement("loan_type")]
        public string LoanType { get; set; }

        /// <summary>
        /// 授信产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}

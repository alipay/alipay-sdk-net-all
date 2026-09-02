using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaasBuyerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SaasBuyerInfo : AopObject
    {
        /// <summary>
        /// 买家标识。buyer_id_type=customer_id时为SaaS 客户 ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家标识类型。customer_id表示SaaS 客户 ID
        /// </summary>
        [XmlElement("buyer_id_type")]
        public string BuyerIdType { get; set; }

        /// <summary>
        /// 企业登记注册号。首次创建银行转账账户时必须提供；中国大陆企业填写统一社会信用代码。
        /// </summary>
        [XmlElement("enterprise_registration_no")]
        public string EnterpriseRegistrationNo { get; set; }

        /// <summary>
        /// 商户名称，默认可选，如下单时需同步开户则必须提供
        /// </summary>
        [XmlElement("out_merchant_name")]
        public string OutMerchantName { get; set; }

        /// <summary>
        /// 外部平台二级商户唯一编码
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }
    }
}

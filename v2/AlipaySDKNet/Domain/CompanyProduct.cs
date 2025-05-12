using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyProduct Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyProduct : AopObject
    {
        /// <summary>
        /// 企业（商户）转账账户ID
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 企业（商户）产品配置
        /// </summary>
        [XmlElement("company_product_config")]
        public CompanyProductConfig CompanyProductConfig { get; set; }

        /// <summary>
        /// 发票产品编号
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 发票产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}

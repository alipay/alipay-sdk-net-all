using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyProductInfo : AopObject
    {
        /// <summary>
        /// 企业产品配置信息
        /// </summary>
        [XmlArray("company_product_config")]
        [XmlArrayItem("company_product_config_info")]
        public List<CompanyProductConfigInfo> CompanyProductConfig { get; set; }

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

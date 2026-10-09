using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderTax Data Structure.
    /// </summary>
    [Serializable]
    public class OrderTax : AopObject
    {
        /// <summary>
        /// 税额（元，两位小数）
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 征收项目代码，与税务机关公布的征收项目代码保持一致
        /// </summary>
        [XmlElement("tax_project_code")]
        public string TaxProjectCode { get; set; }

        /// <summary>
        /// 征收项目名称
        /// </summary>
        [XmlElement("tax_project_name")]
        public string TaxProjectName { get; set; }
    }
}

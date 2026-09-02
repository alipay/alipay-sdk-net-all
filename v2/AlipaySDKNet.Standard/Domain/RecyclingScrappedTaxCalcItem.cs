using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclingScrappedTaxCalcItem Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclingScrappedTaxCalcItem : AopObject
    {
        /// <summary>
        /// 减征比例（个税无，增值税无）
        /// </summary>
        [XmlElement("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 税目编码
        /// </summary>
        [XmlElement("tax_item_code")]
        public string TaxItemCode { get; set; }

        /// <summary>
        /// 税目名称
        /// </summary>
        [XmlElement("tax_item_name")]
        public string TaxItemName { get; set; }

        /// <summary>
        /// 税种项目代码
        /// </summary>
        [XmlElement("tax_project_code")]
        public string TaxProjectCode { get; set; }

        /// <summary>
        /// 税种项目名称
        /// </summary>
        [XmlElement("tax_project_name")]
        public string TaxProjectName { get; set; }

        /// <summary>
        /// 税率或征收率（个税无，增值税无）
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}

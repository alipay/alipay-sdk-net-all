using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DailyUsage Data Structure.
    /// </summary>
    [Serializable]
    public class DailyUsage : AopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 按量付费用量
        /// </summary>
        [XmlElement("excess_usage")]
        public string ExcessUsage { get; set; }

        /// <summary>
        /// 计费项编码
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [XmlElement("fee_item_name")]
        public string FeeItemName { get; set; }

        /// <summary>
        /// 计费项单位（万次，GB秒，GB天，GB）
        /// </summary>
        [XmlElement("fee_item_unit")]
        public string FeeItemUnit { get; set; }

        /// <summary>
        /// 免费额度用量
        /// </summary>
        [XmlElement("free_usage")]
        public string FreeUsage { get; set; }

        /// <summary>
        /// 资源包内用量
        /// </summary>
        [XmlElement("resource_package_usage")]
        public string ResourcePackageUsage { get; set; }

        /// <summary>
        /// 总用量（万次、GB秒、GB、GB天） 总用量 = 免费额度用量 + 资源包内用量 + 按量付费用量
        /// </summary>
        [XmlElement("total_usage")]
        public string TotalUsage { get; set; }
    }
}

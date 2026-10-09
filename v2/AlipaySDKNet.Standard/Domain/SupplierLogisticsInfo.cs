using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierLogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierLogisticsInfo : AopObject
    {
        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}

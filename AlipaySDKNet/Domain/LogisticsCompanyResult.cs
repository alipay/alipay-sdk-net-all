using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsCompanyResult Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsCompanyResult : AopObject
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
    }
}

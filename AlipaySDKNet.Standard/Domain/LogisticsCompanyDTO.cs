using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsCompanyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsCompanyDTO : AopObject
    {
        /// <summary>
        /// 配送公司客服电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 配送公司物流编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司名称
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LatestCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LatestCommissionInfo : AopObject
    {
        /// <summary>
        /// 最新比例，单位为百分比
        /// </summary>
        [XmlElement("latest_rate")]
        public string LatestRate { get; set; }

        /// <summary>
        /// 最新状态
        /// </summary>
        [XmlElement("latest_status")]
        public string LatestStatus { get; set; }
    }
}

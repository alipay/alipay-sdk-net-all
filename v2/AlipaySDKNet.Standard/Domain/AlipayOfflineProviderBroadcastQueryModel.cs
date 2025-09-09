using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderBroadcastQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderBroadcastQueryModel : AopObject
    {
        /// <summary>
        /// 查询的作业截止日期，要求最近60天以内
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 间联商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}

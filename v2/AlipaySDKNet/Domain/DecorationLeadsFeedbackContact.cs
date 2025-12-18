using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DecorationLeadsFeedbackContact Data Structure.
    /// </summary>
    [Serializable]
    public class DecorationLeadsFeedbackContact : AopObject
    {
        /// <summary>
        /// true客户电话可用；false客户电话不可用
        /// </summary>
        [XmlElement("contact_result")]
        public bool ContactResult { get; set; }

        /// <summary>
        /// 与客户建立联系的具体时间
        /// </summary>
        [XmlElement("contact_time")]
        public string ContactTime { get; set; }

        /// <summary>
        /// true：客户可到店；false：客户暂不到店
        /// </summary>
        [XmlElement("in_store")]
        public bool InStore { get; set; }

        /// <summary>
        /// true：客户有意向；false：客户暂无意向
        /// </summary>
        [XmlElement("interest")]
        public bool Interest { get; set; }
    }
}

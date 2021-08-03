using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseBcgroupJoinedConsultResponse.
    /// </summary>
    public class AlipaySocialBaseBcgroupJoinedConsultResponse : AopResponse
    {
        /// <summary>
        /// 入群状态。true为已经入群，false为未入群。
        /// </summary>
        [XmlElement("joined")]
        public bool Joined { get; set; }
    }
}

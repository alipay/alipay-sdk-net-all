using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQipanCrowdoperationCreateResponse.
    /// </summary>
    public class AlipayMarketingQipanCrowdoperationCreateResponse : AopResponse
    {
        /// <summary>
        /// 棋盘人群的唯一编码
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }
    }
}

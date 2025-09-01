using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCreditinfoAuthawardQueryResponse.
    /// </summary>
    public class ZhimaCustomerCreditinfoAuthawardQueryResponse : AopResponse
    {
        /// <summary>
        /// 当auth=true时，才会返回奖励相关信息
        /// </summary>
        [XmlElement("auth")]
        public bool Auth { get; set; }

        /// <summary>
        /// send_award=false，该值不存在 send_award=true，该值为1%~100%（进度值）
        /// </summary>
        [XmlElement("award")]
        public string Award { get; set; }

        /// <summary>
        /// 该授权单号是否发放过授权奖励
        /// </summary>
        [XmlElement("send_award")]
        public bool SendAward { get; set; }
    }
}

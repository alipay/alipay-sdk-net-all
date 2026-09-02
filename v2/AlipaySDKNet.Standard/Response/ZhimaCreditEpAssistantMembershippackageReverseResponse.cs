using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageReverseResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMembershippackageReverseResponse : AopResponse
    {
        /// <summary>
        /// 退权益执行成功的那笔业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退权益状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

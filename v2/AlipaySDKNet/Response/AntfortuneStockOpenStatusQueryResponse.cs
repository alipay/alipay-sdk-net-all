using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockOpenStatusQueryResponse.
    /// </summary>
    public class AntfortuneStockOpenStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户在该机构的签约协议号，是支付宝用户在该机构的唯一标识
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户在该机构的开绑户状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

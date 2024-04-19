using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseBcMsgSendResponse.
    /// </summary>
    public class AlipaySocialBaseBcMsgSendResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码，在业务失败的情况下返回
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务错误描述，在业务失败的情况下返回
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }
    }
}

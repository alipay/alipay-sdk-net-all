using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMsgTextSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalMsgTextSendResponse : AopResponse
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

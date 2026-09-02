using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMsgReachSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalMsgReachSendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("channel_results")]
        [XmlArrayItem("string")]
        public List<string> ChannelResults { get; set; }

        /// <summary>
        /// 业务号，业务方提供
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

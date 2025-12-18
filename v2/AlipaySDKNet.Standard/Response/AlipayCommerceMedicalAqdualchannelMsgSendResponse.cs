using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAqdualchannelMsgSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalAqdualchannelMsgSendResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("msg_id_list")]
        [XmlArrayItem("string")]
        public List<string> MsgIdList { get; set; }

        /// <summary>
        /// 商户订单id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

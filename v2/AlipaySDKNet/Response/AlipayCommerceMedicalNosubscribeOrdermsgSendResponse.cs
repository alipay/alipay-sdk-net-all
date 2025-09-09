using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalNosubscribeOrdermsgSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalNosubscribeOrdermsgSendResponse : AopResponse
    {
        /// <summary>
        /// 支付宝消息id列表
        /// </summary>
        [XmlArray("msg_id_list")]
        [XmlArrayItem("string")]
        public List<string> MsgIdList { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

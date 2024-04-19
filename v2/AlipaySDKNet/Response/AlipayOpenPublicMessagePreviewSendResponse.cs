using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicMessagePreviewSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessagePreviewSendResponse : AopResponse
    {
        /// <summary>
        /// 消息发送错误数据
        /// </summary>
        [XmlArray("error_datas")]
        [XmlArrayItem("msg_send_error_data")]
        public List<MsgSendErrorData> ErrorDatas { get; set; }
    }
}

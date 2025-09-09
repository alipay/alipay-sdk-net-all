using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatMsgCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatMsgCreateResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号，原样返回
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝内部请求号，唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}

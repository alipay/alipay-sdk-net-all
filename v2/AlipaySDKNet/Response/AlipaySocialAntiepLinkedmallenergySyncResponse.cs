using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergySyncResponse.
    /// </summary>
    public class AlipaySocialAntiepLinkedmallenergySyncResponse : AopResponse
    {
        /// <summary>
        /// 订单同步的处理结果描述
        /// </summary>
        [XmlElement("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 订单同步的处理结果码
        /// </summary>
        [XmlElement("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 业务的实际处理结果 biz_success=ture,代表成功；biz_success=false代表失败
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}

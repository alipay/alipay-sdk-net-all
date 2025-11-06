using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergyConsultResponse.
    /// </summary>
    public class AlipaySocialAntiepLinkedmallenergyConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否有下单资格，有资格：true；无资格：false
        /// </summary>
        [XmlElement("allow")]
        public bool Allow { get; set; }

        /// <summary>
        /// 支付前置咨询的处理结果描述，这个文案展示给用户查看
        /// </summary>
        [XmlElement("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 支付前置咨询的处理结果码
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

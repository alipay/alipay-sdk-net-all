using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergyReturnResponse.
    /// </summary>
    public class AlipaySocialAntiepLinkedmallenergyReturnResponse : AopResponse
    {
        /// <summary>
        /// 支持积分的处理结果描述，这个文案展示给用户查看
        /// </summary>
        [XmlElement("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 支持积分的处理结果码
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

using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppDetectCreateResponse.
    /// </summary>
    public class AlipayEbppDetectCreateResponse : AopResponse
    {
        /// <summary>
        /// 外部业务标识，同入参的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductagreementModifyResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductagreementModifyResponse : AopResponse
    {
        /// <summary>
        /// true代表受理成功 false代表受理失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 返回结果编码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}

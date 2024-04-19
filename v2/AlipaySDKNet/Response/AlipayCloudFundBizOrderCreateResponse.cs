using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundBizOrderCreateResponse.
    /// </summary>
    public class AlipayCloudFundBizOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 上报成功/失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}

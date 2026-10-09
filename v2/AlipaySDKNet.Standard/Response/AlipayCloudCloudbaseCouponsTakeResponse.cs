using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsTakeResponse.
    /// </summary>
    public class AlipayCloudCloudbaseCouponsTakeResponse : AopResponse
    {
        /// <summary>
        /// 领券是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}

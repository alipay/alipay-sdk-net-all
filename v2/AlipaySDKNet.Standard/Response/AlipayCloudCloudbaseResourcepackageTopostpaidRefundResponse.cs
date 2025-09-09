using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageTopostpaidRefundResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageTopostpaidRefundResponse : AopResponse
    {
        /// <summary>
        /// 套餐包未使用资源退款是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}

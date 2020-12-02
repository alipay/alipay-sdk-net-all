using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderIstdcancelPreconsultResponse.
    /// </summary>
    public class AlipayCommerceLogisticsOrderIstdcancelPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 是否允许取消
        /// </summary>
        [XmlElement("allow_cancel")]
        public bool AllowCancel { get; set; }
    }
}

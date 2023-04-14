using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherAssociateResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherAssociateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝系统关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("associate_time")]
        public string AssociateTime { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherDisassociateResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherDisassociateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝系统取消关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("disassociate_time")]
        public string DisassociateTime { get; set; }
    }
}

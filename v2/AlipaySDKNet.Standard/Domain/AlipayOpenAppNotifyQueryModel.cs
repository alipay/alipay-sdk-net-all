using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppNotifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppNotifyQueryModel : AopObject
    {
        /// <summary>
        /// trade_no+是+查询该交易编号的信息+根据订单信息拿到
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}

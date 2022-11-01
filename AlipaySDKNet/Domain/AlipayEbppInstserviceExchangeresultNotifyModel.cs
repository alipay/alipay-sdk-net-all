using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceExchangeresultNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceExchangeresultNotifyModel : AopObject
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// S: 兑换成功 F: 兑换失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

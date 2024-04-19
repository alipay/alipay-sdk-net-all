using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantLiveChannelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantLiveChannelQueryModel : AopObject
    {
        /// <summary>
        /// 渠道下单参数(orderStartId)
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }
    }
}

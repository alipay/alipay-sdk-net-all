using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxactivityQueryModel : AopObject
    {
        /// <summary>
        /// 搜索直达活动id
        /// </summary>
        [XmlElement("box_activity_id")]
        public string BoxActivityId { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家"运营支付宝小程序"授权。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}

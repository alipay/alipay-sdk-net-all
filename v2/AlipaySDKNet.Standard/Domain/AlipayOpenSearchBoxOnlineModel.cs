using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxOnlineModel : AopObject
    {
        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家"运营支付宝小程序"授权。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxOfflineModel : AopObject
    {
        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}

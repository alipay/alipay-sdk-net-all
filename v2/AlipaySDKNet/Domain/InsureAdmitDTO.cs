using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsureAdmitDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsureAdmitDTO : AopObject
    {
        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 关键key，识别批量请求准入接口对应的数据
        /// </summary>
        [XmlElement("echo_key")]
        public string EchoKey { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}

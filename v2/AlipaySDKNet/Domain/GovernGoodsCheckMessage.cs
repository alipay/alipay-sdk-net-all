using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GovernGoodsCheckMessage Data Structure.
    /// </summary>
    [Serializable]
    public class GovernGoodsCheckMessage : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 需要治理的地方
        /// </summary>
        [XmlElement("need_grovern_point")]
        public string NeedGrovernPoint { get; set; }

        /// <summary>
        /// 治理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}

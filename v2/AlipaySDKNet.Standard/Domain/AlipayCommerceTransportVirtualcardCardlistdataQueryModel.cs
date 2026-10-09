using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVirtualcardCardlistdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVirtualcardCardlistdataQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询数据标识是什么类型的数据，eg：SPECIAL_IDENTIFICATION特种人群数据
        /// </summary>
        [XmlElement("query_action")]
        public string QueryAction { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

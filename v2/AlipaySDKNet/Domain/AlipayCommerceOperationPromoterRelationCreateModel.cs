using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoterRelationCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoterRelationCreateModel : AopObject
    {
        /// <summary>
        /// 商户小程序appid
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 需要绑定的门店对映的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 海鼎门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 店员id，点击提交的收银员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

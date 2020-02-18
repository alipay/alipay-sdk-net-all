using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMemberDataTagQueryResponse.
    /// </summary>
    public class KoubeiMemberDataTagQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否是会员
        /// </summary>
        [XmlElement("card_member")]
        public bool CardMember { get; set; }

        /// <summary>
        /// 类目标签
        /// </summary>
        [XmlElement("cate_prefer_label")]
        public string CatePreferLabel { get; set; }

        /// <summary>
        /// 潮标签
        /// </summary>
        [XmlElement("fashion_label")]
        public string FashionLabel { get; set; }

        /// <summary>
        /// 口味标签
        /// </summary>
        [XmlElement("taste_prefer_label")]
        public string TastePreferLabel { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

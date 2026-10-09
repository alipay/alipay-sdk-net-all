using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardOrderCreateModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public VirtualItemOrderExtInfo ExtendInfo { get; set; }

        /// <summary>
        /// 字段已废弃，无需传参
        /// </summary>
        [XmlElement("isv_partner_id")]
        public string IsvPartnerId { get; set; }

        /// <summary>
        /// 次卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 字段已废弃，无需传参
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

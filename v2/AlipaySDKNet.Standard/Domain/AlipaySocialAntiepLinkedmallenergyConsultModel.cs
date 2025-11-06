using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntiepLinkedmallenergyConsultModel : AopObject
    {
        /// <summary>
        /// 跳转商品链接时传递，有就透传回来，没有不用传
        /// </summary>
        [XmlElement("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 场景码，如：antforest（蚂蚁森林）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// sku的id
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

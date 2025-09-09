using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergyPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntiepLinkedmallenergyPayModel : AopObject
    {
        /// <summary>
        /// LinkedMall入驻的业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 请求发起的时间，时间格式：yyyyMMddHHmmssSSS
        /// </summary>
        [XmlElement("deducted_date")]
        public string DeductedDate { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// LinkedMall的订单ID
        /// </summary>
        [XmlElement("lm_order_id")]
        public long LmOrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 本次下单需要扣减的能量数
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("right_id")]
        public string RightId { get; set; }

        /// <summary>
        /// 场景码，如：antforest（蚂蚁森林）
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// sku_id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

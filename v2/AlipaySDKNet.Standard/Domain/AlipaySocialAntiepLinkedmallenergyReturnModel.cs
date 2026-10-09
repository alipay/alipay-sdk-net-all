using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntiepLinkedmallenergyReturnModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntiepLinkedmallenergyReturnModel : AopObject
    {
        /// <summary>
        /// LinkedMall分配的业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 原始扣减积分的请求ID
        /// </summary>
        [XmlElement("deducted_request_id")]
        public string DeductedRequestId { get; set; }

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
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景码，如：antforest（蚂蚁森林）
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

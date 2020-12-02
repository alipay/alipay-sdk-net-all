using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUserPointExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationUserPointExchangeModel : AopObject
    {
        /// <summary>
        /// 积分核销ID，验证point与benefitId的一致性，才能使用对应的积分
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 业务发生时间，格式yyyyMMddHHmmssSSS
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 将要扣减的用户积分
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 每次请求必须有唯一号，如果唯一号相等，会进行幂等返回
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景代码，由行业运营平台分配，提供枚举值。 user_id + scene_code 确定扣减积分的场景。
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 请求来源方，由行业运营分配。 例如：linkedmall
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

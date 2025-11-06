using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerPointRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerPointRefundModel : AopObject
    {
        /// <summary>
        /// 业务类型，由芝麻方面分配
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务流水号，会用于幂等性校验，所以请保证每次请求的业务流水号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务场景，由芝麻方面分配
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

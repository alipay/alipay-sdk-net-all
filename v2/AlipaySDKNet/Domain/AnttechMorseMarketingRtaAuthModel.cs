using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingRtaAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingRtaAuthModel : AopObject
    {
        /// <summary>
        /// 活动id描述用户使用这个活动消耗预算，该活动必须是被场景侧曝光过的活动
        /// </summary>
        [XmlArray("campaign_ids")]
        [XmlArrayItem("string")]
        public List<string> CampaignIds { get; set; }

        /// <summary>
        /// mobile_sha_256标识用户唯一信息，通过用户手机号SHA256 哈希后获得
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// 明确操作类型，指定本次请求是冻结或者是解冻操作
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 业务请求唯一标识，用于区别每次请求的不同，可以设置成用户的订单号，接口会用该值进行权益冻结和解冻
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 资源位信息确定商户投放场景，由摩斯同学配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}

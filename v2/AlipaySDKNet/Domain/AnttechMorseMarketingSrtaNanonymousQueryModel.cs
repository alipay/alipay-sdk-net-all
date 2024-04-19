using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingSrtaNanonymousQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingSrtaNanonymousQueryModel : AopObject
    {
        /// <summary>
        /// 多个手机号hash后的值，以为逗号分隔
        /// </summary>
        [XmlElement("anonymous_mobile_sha_256_list")]
        public string AnonymousMobileSha256List { get; set; }

        /// <summary>
        /// 目标用户一次加密密文信息
        /// </summary>
        [XmlElement("blind_mobile_sha_256")]
        public string BlindMobileSha256 { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// string 必填 调用商户的请求唯一标识，业务唯一标识，最大长度128
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }
    }
}

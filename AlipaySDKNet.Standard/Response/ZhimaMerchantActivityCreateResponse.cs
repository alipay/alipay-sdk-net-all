using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantActivityCreateResponse.
    /// </summary>
    public class ZhimaMerchantActivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 芝麻活动号，创建成功后回传，用于商户侧做关联和后续查询。
        /// </summary>
        [XmlElement("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 外部活动号，由ISV传入，无需脱敏，返回为了做芝麻活动号的关联。
        /// </summary>
        [XmlElement("out_activity_no")]
        public string OutActivityNo { get; set; }
    }
}

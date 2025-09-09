using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestWelfareforestBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestWelfareforestBatchqueryModel : AopObject
    {
        /// <summary>
        /// 传入公益林业务项目的编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求来源，由森林侧同学定义给出，例如：youku（优酷）
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

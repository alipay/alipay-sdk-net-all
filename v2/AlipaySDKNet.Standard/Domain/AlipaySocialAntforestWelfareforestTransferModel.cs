using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestWelfareforestTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestWelfareforestTransferModel : AopObject
    {
        /// <summary>
        /// 场景码，也由森林侧开发配置后提供出来
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 可以增加业务标识，如youku-shuochang-20240430-xxx，该字段用于浇水接口幂等。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 公益林浇水能量值，为可选项
        /// </summary>
        [XmlElement("energy")]
        public long Energy { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 由森林同学提供，接口调用方传入相关信息
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 公益林id
        /// </summary>
        [XmlElement("welfare_forest_id")]
        public string WelfareForestId { get; set; }
    }
}

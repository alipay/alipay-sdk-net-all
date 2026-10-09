using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestFreeplantApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestFreeplantApplyModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 上游业务方自己定规则,保证全局唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 森林树项目ID，联系森林业务提供
        /// </summary>
        [XmlElement("project_id")]
        public long ProjectId { get; set; }

        /// <summary>
        /// 访问来源，业务自己定
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

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntiepRightsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntiepRightsSendModel : AopObject
    {
        /// <summary>
        /// 发放权益时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 幂等id
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 公益互娱平台权益id
        /// </summary>
        [XmlElement("rights_id")]
        public string RightsId { get; set; }

        /// <summary>
        /// 发放权益数量
        /// </summary>
        [XmlElement("rights_num")]
        public string RightsNum { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// antforest_double_click
        /// </summary>
        [XmlElement("source_detail_type")]
        public string SourceDetailType { get; set; }
    }
}

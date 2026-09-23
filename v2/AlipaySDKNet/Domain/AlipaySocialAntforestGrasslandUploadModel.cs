using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestGrasslandUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestGrasslandUploadModel : AopObject
    {
        /// <summary>
        /// 行为ID
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 行为数值*100为面积1平米（单位：平米）
        /// </summary>
        [XmlElement("action_value")]
        public long ActionValue { get; set; }

        /// <summary>
        /// 业务唯一值ID
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务时间戳（毫秒）
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 访问来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

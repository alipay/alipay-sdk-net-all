using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsurancePreAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsurancePreAuthInfo : AopObject
    {
        /// <summary>
        /// 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 示例：100.00 单位：元 保留俩位小数
        /// </summary>
        [XmlElement("pre_auth_quota")]
        public string PreAuthQuota { get; set; }
    }
}

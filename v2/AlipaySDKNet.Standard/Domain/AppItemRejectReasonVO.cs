using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemRejectReasonVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemRejectReasonVO : AopObject
    {
        /// <summary>
        /// 示例图片url
        /// </summary>
        [XmlArray("problem_pic")]
        [XmlArrayItem("string")]
        public List<string> ProblemPic { get; set; }

        /// <summary>
        /// 备注原因
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 风险项名称
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }
    }
}

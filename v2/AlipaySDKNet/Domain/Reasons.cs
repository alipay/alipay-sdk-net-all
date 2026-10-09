using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Reasons Data Structure.
    /// </summary>
    [Serializable]
    public class Reasons : AopObject
    {
        /// <summary>
        /// 标识商品具体问题的图片
        /// </summary>
        [XmlArray("problem_pic")]
        [XmlArrayItem("string")]
        public List<string> ProblemPic { get; set; }

        /// <summary>
        /// 描述风险项对应的具体问题
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 描述商品问题的类别，例如“商品页面”、“商品标题”...
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }
    }
}

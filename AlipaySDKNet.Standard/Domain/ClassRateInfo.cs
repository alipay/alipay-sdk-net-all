using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClassRateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ClassRateInfo : AopObject
    {
        /// <summary>
        /// 汇率等级有两种 1.权益等级汇率： - diamond(钻石权益) - platinum(铂金权益) - others(无权益)  2.会员等级汇率：  - diamond(钻石会员)  - platinum(铂金会员)  - golden(黄金会员)  - primary(大众会员)
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 汇率等级描述
        /// </summary>
        [XmlElement("grade_desc")]
        public string GradeDesc { get; set; }

        /// <summary>
        /// 汇率值
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 汇率金额，单位元
        /// </summary>
        [XmlElement("rate_amount")]
        public string RateAmount { get; set; }
    }
}

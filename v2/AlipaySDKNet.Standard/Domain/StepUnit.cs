using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StepUnit Data Structure.
    /// </summary>
    [Serializable]
    public class StepUnit : AopObject
    {
        /// <summary>
        /// 处理时间
        /// </summary>
        [XmlElement("deal_date")]
        public string DealDate { get; set; }

        /// <summary>
        /// memo
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作意见
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }

        /// <summary>
        /// 用户工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}

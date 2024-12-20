using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpReginfoChangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpReginfoChangeInfo : AopObject
    {
        /// <summary>
        /// 变更后的内容
        /// </summary>
        [XmlElement("after_change")]
        public string AfterChange { get; set; }

        /// <summary>
        /// 变更前的内容
        /// </summary>
        [XmlElement("before_change")]
        public string BeforeChange { get; set; }

        /// <summary>
        /// 变更日期
        /// </summary>
        [XmlElement("change_date")]
        public string ChangeDate { get; set; }

        /// <summary>
        /// 企业工商变更事项
        /// </summary>
        [XmlElement("change_matter")]
        public string ChangeMatter { get; set; }

        /// <summary>
        /// 企业工商变更事项详情
        /// </summary>
        [XmlElement("change_matter_details")]
        public string ChangeMatterDetails { get; set; }
    }
}

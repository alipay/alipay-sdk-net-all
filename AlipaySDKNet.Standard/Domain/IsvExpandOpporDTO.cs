using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvExpandOpporDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvExpandOpporDTO : AopObject
    {
        /// <summary>
        /// 商机地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商机Id
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商机名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商机作业Id
        /// </summary>
        [XmlElement("oppor_id")]
        public string OpporId { get; set; }

        /// <summary>
        /// 外部幂等唯一键
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商机联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 商机作业状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

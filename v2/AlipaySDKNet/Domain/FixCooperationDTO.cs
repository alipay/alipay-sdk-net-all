using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FixCooperationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FixCooperationDTO : AopObject
    {
        /// <summary>
        /// 协作任务的处理结论
        /// </summary>
        [XmlElement("conclusion")]
        public string Conclusion { get; set; }

        /// <summary>
        /// 协作任务的唯一id
        /// </summary>
        [XmlElement("cooperation_id")]
        public long CooperationId { get; set; }

        /// <summary>
        /// 协作任务的处理完成时间。
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 协作任务的处理说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 实际处理人的名称
        /// </summary>
        [XmlElement("duty_owner_name")]
        public string DutyOwnerName { get; set; }

        /// <summary>
        /// 协作任务的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 协作任务的处理方公司名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 协作任务的处理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}

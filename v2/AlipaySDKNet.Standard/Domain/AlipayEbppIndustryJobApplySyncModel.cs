using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobApplySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobApplySyncModel : AopObject
    {
        /// <summary>
        /// 应聘信息最新更新时间  如果应聘信息有更新，通过本接口传更新后的信息，以及最新更新时间。  在某些情况下更新信息在本接口无法体现，比如服务商侧的应聘状态更详尽，多种状态对应到本岗位的一个状态，（查看简历、一面中、二面均对应到“应聘中”状态），但从查看简历更新到一面中时，仍需要通过本接口同步最新更新时间，支付宝引导用户到服务商小程序查看最新信息  格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_change_time")]
        public string ApplyChangeTime { get; set; }

        /// <summary>
        /// 小程序应聘详情页地址
        /// </summary>
        [XmlElement("apply_info_url")]
        public string ApplyInfoUrl { get; set; }

        /// <summary>
        /// 状态枚举
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 用户发起应聘的时间  格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 服务商侧该应聘信息的唯一标识，用于做幂等判断。
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 服务商侧应聘的岗位的唯一标识。请确保已经提前将岗位信息同步给支付宝。
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }
    }
}

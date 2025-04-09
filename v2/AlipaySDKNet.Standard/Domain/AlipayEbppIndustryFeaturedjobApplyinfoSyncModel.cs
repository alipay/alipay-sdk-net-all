using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryFeaturedjobApplyinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryFeaturedjobApplyinfoSyncModel : AopObject
    {
        /// <summary>
        /// 应聘信息最新更新时间，如果应聘信息有更新，通过本接口传更新后的信息以及最新更新时间。 在某些情况下更新信息在本接口无法体现，例如服务商侧的应聘状态更详尽，多种状态对应到本岗位的一个状态，（查看简历、一面中、二面均对应到“应聘中”状态），但从查看简历更新到一面中时，仍需要通过本接口同步最新更新时间，支付宝引导用户到服务商小程序查看最新信息 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_change_time")]
        public string ApplyChangeTime { get; set; }

        /// <summary>
        /// 特色专区中报名时携带的支付宝报名id，后续报名状态变更以此id为基准同步
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 应聘链路中的状态变化枚举
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 用户发起应聘的时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 特色专区中报名时携带的支付宝内部岗位id 
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }
    }
}

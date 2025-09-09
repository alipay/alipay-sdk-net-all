using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRecruitApplySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRecruitApplySyncModel : AopObject
    {
        /// <summary>
        /// 应聘信息最新更新时间，如果应聘信息有更新，通过本接口传更新后的信息以及最新更新时间。 在某些情况下更新信息在本接口无法体现，比如服务商侧的应聘状态更详尽，多种状态对应到本岗位的一个状态，（查看简历、一面中、二面均对应到“应聘中”状态），但从查看简历更新到一面中时，仍需要通过本接口同步最新更新时间，支付宝引导用户到服务商小程序查看最新信息 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_change_time")]
        public string ApplyChangeTime { get; set; }

        /// <summary>
        /// 报名用户UID
        /// </summary>
        [XmlElement("apply_open_id")]
        public string ApplyOpenId { get; set; }

        /// <summary>
        /// 报名状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 用户发起应聘的时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 报名用户支付宝UID
        /// </summary>
        [XmlElement("apply_user_id")]
        public string ApplyUserId { get; set; }

        /// <summary>
        /// 业务场景ID，例如招聘专场id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用户端岗位报名详情页
        /// </summary>
        [XmlElement("client_apply_url")]
        public string ClientApplyUrl { get; set; }

        /// <summary>
        /// 不合适原因
        /// </summary>
        [XmlElement("inappropriate_reason")]
        public string InappropriateReason { get; set; }

        /// <summary>
        /// 面试地点
        /// </summary>
        [XmlElement("inter_address")]
        public string InterAddress { get; set; }

        /// <summary>
        /// 面试时间，应聘者到实际到场面试时间，精确到秒
        /// </summary>
        [XmlElement("inter_time")]
        public string InterTime { get; set; }

        /// <summary>
        /// IoT设备SN号，该字段向IoT服务商定向开放，非IoT服务商无需传值
        /// </summary>
        [XmlElement("iot_sn")]
        public string IotSn { get; set; }

        /// <summary>
        /// 报名id
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 服务商侧岗位唯一标识
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 报名管理URL
        /// </summary>
        [XmlElement("server_apply_url")]
        public string ServerApplyUrl { get; set; }

        /// <summary>
        /// 应聘报名投递的数据来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}

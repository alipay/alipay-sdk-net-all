using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJobinterviewInterviewInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJobinterviewInterviewInitializeModel : AopObject
    {
        /// <summary>
        /// 渠道归因码,透传用于面试链接渠道统计。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 供应商侧候选人唯一ID。平台据此生成内部 candidateId,后续查状态/结果/回传时以返回的 candidateId 为准
        /// </summary>
        [XmlElement("external_candidate_id")]
        public string ExternalCandidateId { get; set; }

        /// <summary>
        /// 候选人性别。枚举:男=MALE、女=FEMALE
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 候选人身份证号码,用于身份校验。敏感信息,透传存储、不单独展示,请按数据安全规范传输
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 岗位所在城市行政区划编码(如 330100=杭州),用于城市维度归因
        /// </summary>
        [XmlElement("job_city_code")]
        public string JobCityCode { get; set; }

        /// <summary>
        /// 关联岗位ID
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 招聘岗位名称,用于发送面试短信时展示岗位信息。请与门店实际岗位保持一致
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 候选人真实姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 候选人手机号,用于面试短信通知。敏感信息,请按数据安全规范传输
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 面试间唯一ID,由供应商发布面试间后获得,决定候选人进入哪个面试间
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 供应商接入租户唯一标识,由平台分配,所有接口一致透传
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}

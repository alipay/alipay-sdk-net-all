using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthQuickhireSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthQuickhireSubmitModel : AopObject
    {
        /// <summary>
        /// 投递者年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 求职者手机号，工作证投递链路非必填，非工作证投递链路必填
        /// </summary>
        [XmlElement("contact_no")]
        public string ContactNo { get; set; }

        /// <summary>
        /// 商户侧投递唯一ID，后续芝麻快招同步给商户侧联系情况或者其他信息时候商户侧用此ID进行关联
        /// </summary>
        [XmlElement("deliver_id")]
        public string DeliverId { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("deliver_time")]
        public string DeliverTime { get; set; }

        /// <summary>
        /// 0 = 非工作证投递，1 = 工作证投递
        /// </summary>
        [XmlElement("deliver_type")]
        public long DeliverType { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 选填
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 蚂蚁开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 岗位唯一标识
        /// </summary>
        [XmlElement("recruit_code_id")]
        public string RecruitCodeId { get; set; }

        /// <summary>
        /// 信用服务id,由芝麻信用运营分配，联系业务对接人获得，写死即可
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}

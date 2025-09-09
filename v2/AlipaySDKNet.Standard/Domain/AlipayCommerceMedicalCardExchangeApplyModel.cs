using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardExchangeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardExchangeApplyModel : AopObject
    {
        /// <summary>
        /// 申请数量，单位是个
        /// </summary>
        [XmlElement("apply_sum")]
        public long ApplySum { get; set; }

        /// <summary>
        /// 申请券码时间，毫秒级时间戳 当前字段已废弃(可以通过逻辑查询得到)
        /// </summary>
        [XmlElement("apply_time")]
        public long ApplyTime { get; set; }

        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 外部唯一单号不能为空
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 合作方式
        /// </summary>
        [XmlElement("cooperate_mode")]
        public string CooperateMode { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}

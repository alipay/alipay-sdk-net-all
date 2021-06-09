using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationMobileApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationMobileApplyModel : AopObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [XmlElement("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 保险失效时间
        /// </summary>
        [XmlElement("effective_end_time")]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// 保单生效时间
        /// </summary>
        [XmlElement("effective_start_time")]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [XmlElement("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保障期限 数字加单位，单位包括Y/M/D/H
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保险保费
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 维修类型，官修/非官修
        /// </summary>
        [XmlElement("repair_type")]
        public string RepairType { get; set; }

        /// <summary>
        /// 标准产品ID
        /// </summary>
        [XmlElement("sp_no")]
        public string SpNo { get; set; }
    }
}

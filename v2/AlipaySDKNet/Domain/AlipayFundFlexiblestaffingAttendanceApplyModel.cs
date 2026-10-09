using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAttendanceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingAttendanceApplyModel : AopObject
    {
        /// <summary>
        /// 授权跳转类型
        /// </summary>
        [XmlElement("apply_link_type")]
        public string ApplyLinkType { get; set; }

        /// <summary>
        /// 场景码固定值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳转渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 零工卡信息
        /// </summary>
        [XmlElement("employee_card_info")]
        public EmployeeCardInfoDTO EmployeeCardInfo { get; set; }

        /// <summary>
        /// 链接有效时间，最大值一年有效期
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 打卡的配置信息
        /// </summary>
        [XmlElement("insure_attend")]
        public InsureAttendDTO InsureAttend { get; set; }

        /// <summary>
        /// 当投保模式为直接投保，投保主体信息必选
        /// </summary>
        [XmlElement("insure_info")]
        public InsureInfoDTO InsureInfo { get; set; }

        /// <summary>
        /// 投保模式1：审批投 2：直接投
        /// </summary>
        [XmlElement("insure_type")]
        public string InsureType { get; set; }

        /// <summary>
        /// 员工工种code列表信息，替代原job,job_level字段，该字段必填
        /// </summary>
        [XmlArray("job_list")]
        [XmlArrayItem("string")]
        public List<string> JobList { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商信息,本次场景和投保企业信息报错一致
        /// </summary>
        [XmlElement("partner_organization")]
        public InsurePartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 产品码固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}

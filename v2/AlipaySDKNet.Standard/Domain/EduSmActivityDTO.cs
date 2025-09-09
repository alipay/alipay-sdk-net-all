using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduSmActivityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EduSmActivityDTO : AopObject
    {
        /// <summary>
        /// 活动码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [XmlElement("audit_date")]
        public string AuditDate { get; set; }

        /// <summary>
        /// 审批流审核备注信息
        /// </summary>
        [XmlElement("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 服务商PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 间联商户名称
        /// </summary>
        [XmlElement("sm_cn_name")]
        public string SmCnName { get; set; }

        /// <summary>
        /// 间联商户ID
        /// </summary>
        [XmlElement("sm_id")]
        public string SmId { get; set; }

        /// <summary>
        /// 间联商户级别
        /// </summary>
        [XmlElement("sm_level")]
        public string SmLevel { get; set; }

        /// <summary>
        /// 间联商户经营类目
        /// </summary>
        [XmlElement("sm_mcc")]
        public string SmMcc { get; set; }

        /// <summary>
        /// 间联商户经营类目名称
        /// </summary>
        [XmlElement("sm_mcc_name")]
        public string SmMccName { get; set; }

        /// <summary>
        /// 间联商户新经营类目
        /// </summary>
        [XmlElement("sm_new_mcc")]
        public string SmNewMcc { get; set; }

        /// <summary>
        /// 间联商户新经营类目名称
        /// </summary>
        [XmlElement("sm_new_mcc_name")]
        public string SmNewMccName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

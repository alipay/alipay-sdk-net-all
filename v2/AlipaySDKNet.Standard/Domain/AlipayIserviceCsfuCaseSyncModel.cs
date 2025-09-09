using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsfuCaseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsfuCaseSyncModel : AopObject
    {
        /// <summary>
        /// 案件编号，租户内全局唯一
        /// </summary>
        [XmlElement("biz_case_no")]
        public string BizCaseNo { get; set; }

        /// <summary>
        /// 案件的逾期日期，例如逾期时间为2025-01-01 00:00:00，当前时刻为2025-01-03 00:00:00，则表示逾期的时间为2天
        /// </summary>
        [XmlElement("case_overdue_date")]
        public string CaseOverdueDate { get; set; }

        /// <summary>
        /// 案件所支持的方案列表，一个案件可支持多个方案
        /// </summary>
        [XmlArray("case_plans")]
        [XmlArrayItem("string")]
        public List<string> CasePlans { get; set; }

        /// <summary>
        /// 委案结束时间
        /// </summary>
        [XmlElement("commission_end_time")]
        public string CommissionEndTime { get; set; }

        /// <summary>
        /// 委案开始时间
        /// </summary>
        [XmlElement("commission_start_time")]
        public string CommissionStartTime { get; set; }

        /// <summary>
        /// 案件所关联的联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 扩展信息字段有以下字段：  1. **应催金额 (need_coll_amt)**; 2. **总欠款金额(total_due_amt)**; 3. **逾期本金(prin_ovd_amt)**; 4. **欠款产品(due_product)**;。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 业务方侧的全局唯一id，用以幂等处理
        /// </summary>
        [XmlElement("external_contact_id")]
        public string ExternalContactId { get; set; }

        /// <summary>
        /// 案件所绑定客户的证件号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 案件所关联客户的联系方式，明文
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 租户实例id，必填，平台分配
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 案件所关联联系人的类型，区分个人和企业
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}

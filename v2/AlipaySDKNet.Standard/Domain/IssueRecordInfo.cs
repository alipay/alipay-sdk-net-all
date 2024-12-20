using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IssueRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IssueRecordInfo : AopObject
    {
        /// <summary>
        /// 发放额度对应的币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 发放金额，支持两位小数，单位为（元）
        /// </summary>
        [XmlElement("issue_quota")]
        public string IssueQuota { get; set; }

        /// <summary>
        /// 发放状态描述 0: "未发放" 1: "发放成功" 2: "待作废" 3: "已作废" 4: "作废失败，有消费记录" 5: "发放中"
        /// </summary>
        [XmlElement("issue_status")]
        public long IssueStatus { get; set; }

        /// <summary>
        /// 根据owner_type返回对应的owner_id，例如：owner_type为PHONE，则owner_id返回手机号
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：owner_type为PHONE，返回员工手机号，owner_type为EMPLOYEE，返回员工open_id，owner_type为ENTERPRISE_PAY_UID，返回员工企业码id
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 用来指定owner_id的类型，具体返回值参考枚举值
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 发放状态为发放成功的可返回额度id，未发放和发放中的无法返回额度id
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }

        /// <summary>
        /// 发放对应的员工名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}

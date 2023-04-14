using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxBasicInfoModule Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxBasicInfoModule : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 介绍，已生效的数据
        /// </summary>
        [XmlElement("box_desc")]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 介绍，最近一次审核内容
        /// </summary>
        [XmlElement("latest_audit_box_desc")]
        public string LatestAuditBoxDesc { get; set; }

        /// <summary>
        /// 模块配置ID
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图
        /// </summary>
        [XmlElement("module_type")]
        public string ModuleType { get; set; }

        /// <summary>
        /// 状态，INITIAL-初始/AUDIT-审核中/CANCEL-已取消/ONLINE-已上架/REJECT-驳回/OFFLINE-已下架/EXPIRE-已失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

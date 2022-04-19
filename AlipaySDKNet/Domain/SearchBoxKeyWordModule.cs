using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxKeyWordModule Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxKeyWordModule : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

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
        /// 自定义触发词(生效中)
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 自定义触发词(最近一次审核内容)
        /// </summary>
        [XmlArray("latest_audit_keywords")]
        [XmlArrayItem("string")]
        public List<string> LatestAuditKeywords { get; set; }

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

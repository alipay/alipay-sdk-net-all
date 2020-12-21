using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchApplyPageQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchApplyPageQueryRequest : AopObject
    {
        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 筛选状态数组 AUDIT AGREE REJECT CANCEL EDIT
        /// </summary>
        [XmlArray("audit_status_list")]
        [XmlArrayItem("string")]
        public List<string> AuditStatusList { get; set; }

        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页面的显示记录条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 起始记录，起始：0
        /// </summary>
        [XmlElement("start_row")]
        public string StartRow { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }
    }
}

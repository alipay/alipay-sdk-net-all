using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasDesignPageBatchqueryModel : AopObject
    {
        /// <summary>
        /// 创建人名字
        /// </summary>
        [XmlElement("creator_name")]
        public string CreatorName { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [XmlElement("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}

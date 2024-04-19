using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherBatchqueryModel : AopObject
    {
        /// <summary>
        /// 券业务编码
        /// </summary>
        [XmlArray("biz_codes")]
        [XmlArrayItem("string")]
        public List<string> BizCodes { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [XmlElement("create_end_time")]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 创建券的开始时间
        /// </summary>
        [XmlElement("create_start_time")]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 冻结码列表
        /// </summary>
        [XmlArray("freeze_codes")]
        [XmlArrayItem("string")]
        public List<string> FreezeCodes { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 券产品码列表
        /// </summary>
        [XmlArray("product_codes")]
        [XmlArrayItem("string")]
        public List<string> ProductCodes { get; set; }

        /// <summary>
        /// 查询排序类型，可选（drawTime：券领取时间，startTime：券开始使用时间）
        /// </summary>
        [XmlElement("sort_type")]
        public string SortType { get; set; }

        /// <summary>
        /// ENABLED查询可用券
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// key:value,如果根据tag标签查询，则传{"tag":["hz_tongyong"]}
        /// </summary>
        [XmlElement("template_extend_info")]
        public string TemplateExtendInfo { get; set; }

        /// <summary>
        /// 指定模板列表查询，只查询这些模板下面的券
        /// </summary>
        [XmlArray("template_ids")]
        [XmlArrayItem("string")]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// 唯一信息（用于透传用户信息）
        /// </summary>
        [XmlElement("user_info")]
        public VcpUniqueInfo UserInfo { get; set; }

        /// <summary>
        /// key:value,如果根据tag标签查询，则传{"tag":["hz_tongyong"]}
        /// </summary>
        [XmlElement("voucher_extend_info")]
        public string VoucherExtendInfo { get; set; }
    }
}

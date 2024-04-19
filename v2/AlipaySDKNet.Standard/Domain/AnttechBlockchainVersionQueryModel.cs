using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainVersionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainVersionQueryModel : AopObject
    {
        /// <summary>
        /// 商务ID
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否部署
        /// </summary>
        [XmlElement("is_troop")]
        public bool IsTroop { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        [XmlElement("product_line_id")]
        public string ProductLineId { get; set; }

        /// <summary>
        /// BAAS公有云3月中旬迭代
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_num")]
        public string VersionNum { get; set; }
    }
}

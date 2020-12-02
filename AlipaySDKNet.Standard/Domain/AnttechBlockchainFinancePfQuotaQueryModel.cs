using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfQuotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinancePfQuotaQueryModel : AopObject
    {
        /// <summary>
        /// 客户号
        /// </summary>
        [XmlElement("client_no")]
        public string ClientNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("crf_type")]
        public string CrfType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("id_num")]
        public string IdNum { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 平台号
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}

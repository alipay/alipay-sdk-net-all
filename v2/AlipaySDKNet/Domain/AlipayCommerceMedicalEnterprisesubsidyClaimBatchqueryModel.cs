using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEnterprisesubsidyClaimBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEnterprisesubsidyClaimBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业编号
        /// </summary>
        [XmlElement("cur_company_id")]
        public string CurCompanyId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_datetime")]
        public string EndDatetime { get; set; }

        /// <summary>
        /// 上级企业编号
        /// </summary>
        [XmlElement("father_company_id")]
        public string FatherCompanyId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("start_datetime")]
        public string StartDatetime { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceCrossborderMerchantBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceCrossborderMerchantBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务来源，由合规平台分配，如：CHYISHE
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 跨境商户基础信息List
        /// </summary>
        [XmlArray("org_list")]
        [XmlArrayItem("base_crossborder_merchant_info")]
        public List<BaseCrossborderMerchantInfo> OrgList { get; set; }

        /// <summary>
        /// 外部业务号：20210701WF001
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 批次查询总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}

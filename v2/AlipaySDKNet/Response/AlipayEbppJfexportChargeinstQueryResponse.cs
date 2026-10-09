using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfexportChargeinstQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportChargeinstQueryResponse : AopResponse
    {
        /// <summary>
        /// 输出的机构列表
        /// </summary>
        [XmlArray("charge_insts")]
        [XmlArrayItem("jf_export_charge_inst_model")]
        public List<JfExportChargeInstModel> ChargeInsts { get; set; }

        /// <summary>
        /// 开通的出账机构总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsSupplierreportdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 盘点单信息
        /// </summary>
        [XmlElement("supplier_report")]
        public SupplierReport SupplierReport { get; set; }

        /// <summary>
        /// 盘点单明细记录
        /// </summary>
        [XmlArray("supplier_report_details")]
        [XmlArrayItem("supplier_report_detail")]
        public List<SupplierReportDetail> SupplierReportDetails { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceItemGreenenergyBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceItemGreenenergyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 能量领取流水
        /// </summary>
        [XmlArray("green_energy_logs")]
        [XmlArrayItem("green_energy_logs_d_t_o")]
        public List<GreenEnergyLogsDTO> GreenEnergyLogs { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}

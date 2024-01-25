using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdRaasMeterQueryResponse.
    /// </summary>
    public class AlipaySecurityProdRaasMeterQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的数据集
        /// </summary>
        [XmlArray("biz_report_datas")]
        [XmlArrayItem("raas_meter_sync_data")]
        public List<RaasMeterSyncData> BizReportDatas { get; set; }

        /// <summary>
        /// 计量待上报的总笔数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}

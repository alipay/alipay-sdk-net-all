using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseReimburseQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiEnterpriseReimburseQueryResponse : AopResponse
    {
        /// <summary>
        /// 导出数据详情列表
        /// </summary>
        [XmlArray("record_detail_list")]
        [XmlArrayItem("record_detail")]
        public List<RecordDetail> RecordDetailList { get; set; }
    }
}

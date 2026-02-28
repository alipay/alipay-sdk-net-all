using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IitBizDetailBillQueryPageResultOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IitBizDetailBillQueryPageResultOpenApiDTO : AopObject
    {
        /// <summary>
        /// 计税是否完成
        /// </summary>
        [XmlElement("calc_finish")]
        public bool CalcFinish { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("iit_biz_detail_bill_detail_open_api_d_t_o")]
        public List<IitBizDetailBillDetailOpenApiDTO> Datas { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}

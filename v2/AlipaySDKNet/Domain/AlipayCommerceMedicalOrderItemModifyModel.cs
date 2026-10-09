using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderItemModifyModel : AopObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商品追溯码信息
        /// </summary>
        [XmlArray("trace_code_infos")]
        [XmlArrayItem("trace_code_info")]
        public List<TraceCodeInfo> TraceCodeInfos { get; set; }
    }
}

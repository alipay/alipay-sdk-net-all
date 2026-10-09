using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHospitalOrderUploadResult Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHospitalOrderUploadResult : AopObject
    {
        /// <summary>
        /// 支付宝行业侧订单号列表
        /// </summary>
        [XmlArray("order_id_list")]
        [XmlArrayItem("string")]
        public List<string> OrderIdList { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 链路追踪id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentOperationAuthDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AgentOperationAuthDetail : AopObject
    {
        /// <summary>
        /// 代运营授权产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 代运营作业子单号，以产品维度拆分子项
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}

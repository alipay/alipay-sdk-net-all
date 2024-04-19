using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbProductOrderQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class HbProductOrderQueryResponse : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 合约订购列表
        /// </summary>
        [XmlArray("product_order_list")]
        [XmlArrayItem("product_order_d_t_o")]
        public List<ProductOrderDTO> ProductOrderList { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}

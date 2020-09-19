using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditmerchantProductorderQueryModel : AopObject
    {
        /// <summary>
        /// 合约订购查询业务场景
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 请求来源应用
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 支付宝商户ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 查询条件集合
        /// </summary>
        [XmlArray("product_order_query_items")]
        [XmlArrayItem("product_order_query_item")]
        public List<ProductOrderQueryItem> ProductOrderQueryItems { get; set; }
    }
}

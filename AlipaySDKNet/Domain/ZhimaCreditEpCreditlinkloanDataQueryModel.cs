using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkloanDataQueryModel : AopObject
    {
        /// <summary>
        /// 查询的数据类型，是列表类型
        /// </summary>
        [XmlArray("collect_data_type")]
        [XmlArrayItem("string")]
        public List<string> CollectDataType { get; set; }

        /// <summary>
        /// 商户自身的单号，需保证其唯一性
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}

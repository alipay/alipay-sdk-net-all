using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementPriceInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementPriceInfoVO : AopObject
    {
        /// <summary>
        /// 订单金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pay_items")]
        [XmlArrayItem("rent_procurement_pay_item_info_v_o")]
        public List<RentProcurementPayItemInfoVO> PayItems { get; set; }
    }
}

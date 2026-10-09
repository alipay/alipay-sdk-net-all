using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoOrderQueryResponse.
    /// </summary>
    public class AntMerchantExpandEcoOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 生态供应商订单维度账单明细
        /// </summary>
        [XmlArray("eco_order_bill_details")]
        [XmlArrayItem("asset_eco_order_bill_detail")]
        public List<AssetEcoOrderBillDetail> EcoOrderBillDetails { get; set; }
    }
}

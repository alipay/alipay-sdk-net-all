using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoBillQueryResponse.
    /// </summary>
    public class AntMerchantExpandEcoBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 生态供应商账单明细
        /// </summary>
        [XmlArray("eco_bill_details")]
        [XmlArrayItem("asset_eco_bill_detail")]
        public List<AssetEcoBillDetail> EcoBillDetails { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantBillQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("hb_merchant_bill")]
        public List<HbMerchantBill> BillList { get; set; }

        /// <summary>
        /// 条目数，最多20000条，多余20000条请细分时间获取
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }
    }
}

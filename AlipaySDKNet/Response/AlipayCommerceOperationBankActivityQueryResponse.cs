using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBankActivityQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationBankActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息列表
        /// </summary>
        [XmlArray("activity_info_list")]
        [XmlArrayItem("bank_activity_info")]
        public List<BankActivityInfo> ActivityInfoList { get; set; }

        /// <summary>
        /// 商户标签
        /// </summary>
        [XmlElement("merchant_tag")]
        public string MerchantTag { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilllistQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabilllistQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单数量
        /// </summary>
        [XmlElement("bill_count")]
        public long BillCount { get; set; }

        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("bill_info")]
        public List<BillInfo> BillList { get; set; }
    }
}

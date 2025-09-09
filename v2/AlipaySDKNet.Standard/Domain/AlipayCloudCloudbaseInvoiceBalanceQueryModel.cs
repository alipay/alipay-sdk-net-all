using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseInvoiceBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseInvoiceBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 订单号列表
        /// </summary>
        [XmlArray("order_no_list")]
        [XmlArrayItem("string")]
        public List<string> OrderNoList { get; set; }
    }
}

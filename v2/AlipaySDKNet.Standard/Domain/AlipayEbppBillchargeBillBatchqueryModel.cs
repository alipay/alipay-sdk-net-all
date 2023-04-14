using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppBillchargeBillBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppBillchargeBillBatchqueryModel : AopObject
    {
        /// <summary>
        /// 待查账的户号列表
        /// </summary>
        [XmlArray("billkey_list")]
        [XmlArrayItem("bill_key_info")]
        public List<BillKeyInfo> BillkeyList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 来源渠道，由支付宝侧分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppBillchargeOrderBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppBillchargeOrderBatchcreateModel : AopObject
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("selected_bill_info")]
        public List<SelectedBillInfo> BillList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1234567890
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 总支付金额
        /// </summary>
        [XmlElement("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

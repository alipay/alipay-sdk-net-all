using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpIsvBillSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpIsvBillSyncModel : AopObject
    {
        /// <summary>
        /// 账单结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 出账时间，回传出账信息时，必须传递
        /// </summary>
        [XmlElement("generate_time")]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 服务优选商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 外部业务号，传isv系统生成的账单号，需要保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 账单支付时间，回传支付数时，必须传递
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 账单金额，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        [XmlElement("promotor_pid")]
        public string PromotorPid { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// GENERATE_BILL代表”已出账“，PAID_BILL代表”已支付“，选择这两者之一
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// S1回传的S2的操作员工子账号，如果是子账号操作，请回传
        /// </summary>
        [XmlElement("sub_promotor_pid")]
        public string SubPromotorPid { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserBillTaxDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserBillTaxDetail : AopObject
    {
        /// <summary>
        /// 小二2088ID，用户id
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 该小二的总税金，单位：元
        /// </summary>
        [XmlElement("amount_tax")]
        public string AmountTax { get; set; }

        /// <summary>
        /// 城建税
        /// </summary>
        [XmlElement("bill_city_tax")]
        public string BillCityTax { get; set; }

        /// <summary>
        /// 教育附加税，单位：元
        /// </summary>
        [XmlElement("bill_edu_tax")]
        public string BillEduTax { get; set; }

        /// <summary>
        /// 个人所得税，单位：元
        /// </summary>
        [XmlElement("bill_iit_tax")]
        public string BillIitTax { get; set; }

        /// <summary>
        /// 地方教育附加税，单位：元
        /// </summary>
        [XmlElement("bill_local_edu_tax")]
        public string BillLocalEduTax { get; set; }

        /// <summary>
        /// 增值税，单位：元
        /// </summary>
        [XmlElement("bill_vat_tax")]
        public string BillVatTax { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 计税失败原因，描述计税失败的原因
        /// </summary>
        [XmlElement("tax_fail_reason")]
        public string TaxFailReason { get; set; }

        /// <summary>
        /// 计税状态；1-计税成功；2-计税失败；
        /// </summary>
        [XmlElement("tax_status")]
        public long TaxStatus { get; set; }

        /// <summary>
        /// 小二薪酬单据编号，全局唯一
        /// </summary>
        [XmlElement("user_bill_no")]
        public string UserBillNo { get; set; }
    }
}

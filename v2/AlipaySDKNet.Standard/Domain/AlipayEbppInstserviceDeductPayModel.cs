using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceDeductPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceDeductPayModel : AopObject
    {
        /// <summary>
        /// 支付宝代扣协议Id
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 帐期，示例值代表2020年8月份
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 在充值场景为手机号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 代扣类型
        /// </summary>
        [XmlElement("ededuct_product_code")]
        public string EdeductProductCode { get; set; }

        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [XmlElement("fine_amount")]
        public string FineAmount { get; set; }

        /// <summary>
        /// 分配机构的唯一ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 支付宝用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户外部业务流水号（用做幂等字段）
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扣款金额，支付总金额，包含滞纳金，单位为元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 商户PartnerId
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

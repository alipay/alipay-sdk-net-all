using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAllocReverseTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAllocReverseTransferModel : AopObject
    {
        /// <summary>
        /// 正向分佣时使用的协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 退分佣金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 退分佣的凭证
        /// </summary>
        [XmlElement("certification")]
        public CertificationForm Certification { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退分佣付款方
        /// </summary>
        [XmlElement("payer")]
        public ParticipantPartyForm Payer { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 分佣退款备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}

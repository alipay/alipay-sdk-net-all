using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAllocTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAllocTransferModel : AopObject
    {
        /// <summary>
        /// 该笔分佣基于该协议号进行的分佣
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 分佣金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 场景码，固定值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 该笔分佣操作基于此凭证进行分佣。
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
        /// 收款人信息
        /// </summary>
        [XmlElement("payee")]
        public ParticipantPartyForm Payee { get; set; }

        /// <summary>
        /// 接口调用的产品码，固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 分佣备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}

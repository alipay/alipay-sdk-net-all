using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletTransferCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletTransferCreateModel : AopObject
    {
        /// <summary>
        /// 金额大小，单位为元，精确到分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 互转操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 操作人的支付宝用户userId。
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转入方信息
        /// </summary>
        [XmlElement("payee_fund_detail")]
        public WalletTransferInfo PayeeFundDetail { get; set; }

        /// <summary>
        /// 转出方信息
        /// </summary>
        [XmlElement("payer_fund_detail")]
        public WalletTransferInfo PayerFundDetail { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}

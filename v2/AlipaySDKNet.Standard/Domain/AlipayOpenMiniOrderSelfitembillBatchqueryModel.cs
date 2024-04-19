using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderSelfitembillBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderSelfitembillBatchqueryModel : AopObject
    {
        /// <summary>
        /// 凭证号，商家可入参具体凭证号查询单个凭证的明细
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 商家订单凭证的核销状态，下钻到次序号维度
        /// </summary>
        [XmlElement("certificate_status")]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// 小程序ID，必填
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 凭证核销的次序号 例：商品为次卡，可使用三次，则一个凭证能够进行三次核销，生成三个核销次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 当前凭证的结算状态，下钻到次序号维度
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 小程序订单结算日期，格式为"yyyy-MM-dd"，如"2023-03-22"
        /// </summary>
        [XmlElement("settlement_date")]
        public string SettlementDate { get; set; }

        /// <summary>
        /// 当前凭证核销门店的ID
        /// </summary>
        [XmlElement("verification_shop_id")]
        public string VerificationShopId { get; set; }

        /// <summary>
        /// 小程序订单核销日期，格式为"yyyy-MM-dd"，如"2023-03-22"
        /// </summary>
        [XmlElement("verify_date")]
        public string VerifyDate { get; set; }
    }
}

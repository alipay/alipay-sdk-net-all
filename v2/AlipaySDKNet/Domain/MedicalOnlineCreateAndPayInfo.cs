using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalOnlineCreateAndPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalOnlineCreateAndPayInfo : AopObject
    {
        /// <summary>
        /// 渠道订单流水号
        /// </summary>
        [XmlElement("chnl_ord_sn")]
        public string ChnlOrdSn { get; set; }

        /// <summary>
        /// 医院订单号(入参中的医院订单号)
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 第三方平台商单号(入参中的第三方平台商号)
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付订单号(入参中的支付订单号)
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付宝中间页链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

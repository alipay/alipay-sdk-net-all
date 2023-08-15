using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAeprepayAcoountSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAeprepayAcoountSettleModel : AopObject
    {
        /// <summary>
        /// 实际平账金额。单位：元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 实际平账币种
        /// </summary>
        [XmlElement("actual_amount_currency")]
        public string ActualAmountCurrency { get; set; }

        /// <summary>
        /// 申请平账金额。单位：元
        /// </summary>
        [XmlElement("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 申请平账币种
        /// </summary>
        [XmlElement("apply_amount_currency")]
        public string ApplyAmountCurrency { get; set; }

        /// <summary>
        /// 还款渠道； INITIATIVE_REPAY：主动还款  TRADEDRIVE_REPAY：交易驱动
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展预留
        /// </summary>
        [XmlElement("ext_param")]
        public ZmEpAePrepayExtParam ExtParam { get; set; }

        /// <summary>
        /// 商家登陆id
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 销账幂等单号
        /// </summary>
        [XmlElement("write_off_apply_no")]
        public string WriteOffApplyNo { get; set; }

        /// <summary>
        /// 销账订单列表
        /// </summary>
        [XmlArray("write_off_order_param_list")]
        [XmlArrayItem("zmep_ae_prepay_write_off_detail_d_t_o")]
        public List<ZmepAePrepayWriteOffDetailDTO> WriteOffOrderParamList { get; set; }
    }
}

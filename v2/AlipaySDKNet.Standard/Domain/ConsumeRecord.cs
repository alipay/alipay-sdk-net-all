using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumeRecord Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumeRecord : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [XmlElement("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务状态文案
        /// </summary>
        [XmlElement("biz_state_desc")]
        public string BizStateDesc { get; set; }

        /// <summary>
        /// 账单金额，单位元
        /// </summary>
        [XmlElement("consume_fee")]
        public string ConsumeFee { get; set; }

        /// <summary>
        /// 删除类型
        /// </summary>
        [XmlElement("delete_type")]
        public string DeleteType { get; set; }

        /// <summary>
        /// 资金明细列表
        /// </summary>
        [XmlArray("fund_items")]
        [XmlArrayItem("fund_item")]
        public List<FundItem> FundItems { get; set; }

        /// <summary>
        /// 业务创建时间
        /// </summary>
        [XmlElement("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 业务更新时间
        /// </summary>
        [XmlElement("gmt_biz_modified")]
        public string GmtBizModified { get; set; }

        /// <summary>
        /// 资金流向（收入/支出）
        /// </summary>
        [XmlElement("in_out")]
        public string InOut { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 本方卡号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 对方展示logo
        /// </summary>
        [XmlElement("opposite_logo")]
        public string OppositeLogo { get; set; }

        /// <summary>
        /// 对方展示名称
        /// </summary>
        [XmlElement("opposite_name")]
        public string OppositeName { get; set; }

        /// <summary>
        /// 本方卡号
        /// </summary>
        [XmlElement("owner_card_no")]
        public string OwnerCardNo { get; set; }

        /// <summary>
        /// 本方登录id（脱敏）
        /// </summary>
        [XmlElement("owner_logon_id")]
        public string OwnerLogonId { get; set; }

        /// <summary>
        /// 本方名称（脱敏)
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 是否是退款
        /// </summary>
        [XmlElement("refund")]
        public bool Refund { get; set; }
    }
}

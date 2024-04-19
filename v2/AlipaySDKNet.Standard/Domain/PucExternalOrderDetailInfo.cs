using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PucExternalOrderDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PucExternalOrderDetailInfo : AopObject
    {
        /// <summary>
        /// 缴费收费账号, 由收费单位定义
        /// </summary>
        [XmlElement("billkey")]
        public string Billkey { get; set; }

        /// <summary>
        /// 缴费业务类型, 默认JF
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 缴费收费单位短名, 由缴费系统生成唯一标识
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 业务受理单号用于唯一标识每一笔交易请求, 和交易订单号1:1对应
        /// </summary>
        [XmlElement("external_biz_id")]
        public string ExternalBizId { get; set; }

        /// <summary>
        /// 商户侧订单的唯一标识, 商户侧保持唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 缴费子业务类型, 关联费种
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}

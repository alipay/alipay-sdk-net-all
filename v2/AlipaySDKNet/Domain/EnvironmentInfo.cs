using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnvironmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnvironmentInfo : AopObject
    {
        /// <summary>
        /// 对应商品有环保类型时，需要返回;一个商品可能有多个环保类型
        /// </summary>
        [XmlArray("environmental_list")]
        [XmlArrayItem("environmental")]
        public List<Environmental> EnvironmentalList { get; set; }

        /// <summary>
        /// 订单回传商品维度失败字典值对应数值：ACTIVITY_NOT_EXISTS、OVER_ACTIVITY_LIMITATION
        /// </summary>
        [XmlElement("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// 订单回传商品维度失败错误原因：活动不存在或已过期、超过活动库存限制
        /// </summary>
        [XmlElement("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// 商品码，根据入参时的商品码进行返回; (其中临期商品一笔订单只返回一个环保类型对应其中一个商品）
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 外部商户订单号，out_biz_no唯一对应一笔订单。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}

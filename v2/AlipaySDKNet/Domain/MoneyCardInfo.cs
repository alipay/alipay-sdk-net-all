using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MoneyCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MoneyCardInfo : AopObject
    {
        /// <summary>
        /// 可使用天数，单位天(购卡后立即生效，生效后x天失效）
        /// </summary>
        [XmlElement("effective_duration")]
        public long EffectiveDuration { get; set; }

        /// <summary>
        /// 客服电话。请确认是一个正常的电话
        /// </summary>
        [XmlElement("hotline")]
        public string Hotline { get; set; }

        /// <summary>
        /// 每人限制购买数量，单位个
        /// </summary>
        [XmlElement("limit_num")]
        public long LimitNum { get; set; }

        /// <summary>
        /// 购买限制类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 面额价，不支持小数，单位分。 字段值需要大于或等于sale_price。
        /// </summary>
        [XmlElement("origin_price")]
        public long OriginPrice { get; set; }

        /// <summary>
        /// 收单账号PID。可在哪些收单账号下核销（分页查询接口不返回）
        /// </summary>
        [XmlArray("pids")]
        [XmlArrayItem("string")]
        public List<string> Pids { get; set; }

        /// <summary>
        /// 剩余库存，单位个。分页查询接口返回
        /// </summary>
        [XmlElement("remain_stock")]
        public long RemainStock { get; set; }

        /// <summary>
        /// 实际售卖价格，不支持小数，单位分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 卡库存，单位个
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 是否支持用户主动退卡。true表示用户可在有效期内主动退卡，无需商家操作，false表示商家可在后台订单管理中手动操作退卡，用户可电话联系商家协商退款 当前字段已废弃(因是否支持退卡新增参数值，该字段已废弃，请使用最外层的support_withdraw字段)
        /// </summary>
        [XmlElement("support_withdraw")]
        public bool SupportWithdraw { get; set; }

        /// <summary>
        /// 使用时段（分页查询接口不返回)。用于设置商品的使用时段
        /// </summary>
        [XmlElement("use_duration")]
        public UseDuration UseDuration { get; set; }

        /// <summary>
        /// 用户核销方式
        /// </summary>
        [XmlArray("use_method")]
        [XmlArrayItem("card_use_method_info")]
        public List<CardUseMethodInfo> UseMethod { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }
    }
}

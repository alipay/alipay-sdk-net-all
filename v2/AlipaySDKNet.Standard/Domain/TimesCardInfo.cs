using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimesCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimesCardInfo : AopObject
    {
        /// <summary>
        /// 违约金信息 当前字段已废弃(违约金信息作为通用能力进行支持，请使用最外层的break_costs_info参数)
        /// </summary>
        [XmlElement("break_costs_info")]
        public BreakCostsInfo BreakCostsInfo { get; set; }

        /// <summary>
        /// 资金模式，预付或先享
        /// </summary>
        [XmlArray("funding_model")]
        [XmlArrayItem("string")]
        public List<string> FundingModel { get; set; }

        /// <summary>
        /// 当limit_type= LIMIT时，必选
        /// </summary>
        [XmlElement("limit_num")]
        public long LimitNum { get; set; }

        /// <summary>
        /// 购买限制类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [XmlElement("remain_stock")]
        public long RemainStock { get; set; }

        /// <summary>
        /// 卡库存，单位个，不传则不限库存
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
    }
}

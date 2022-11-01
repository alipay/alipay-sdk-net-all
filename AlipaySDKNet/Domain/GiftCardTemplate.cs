using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftCardTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class GiftCardTemplate : AopObject
    {
        /// <summary>
        /// 开卡模版扩展参数
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [XmlElement("denomination")]
        public string Denomination { get; set; }

        /// <summary>
        /// 绝对模式用户最晚可以进行绑定的时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 绝对模式用户最早进行绑定的时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 礼品卡模版名字
        /// </summary>
        [XmlElement("gift_card_template_name")]
        public string GiftCardTemplateName { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 待结算户账号
        /// </summary>
        [XmlElement("settle_account_no")]
        public string SettleAccountNo { get; set; }

        /// <summary>
        /// 生效开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 用户绑定后的卡的有效期 绝对模式
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }

        /// <summary>
        /// 生效周期
        /// </summary>
        [XmlElement("valid_period")]
        public string ValidPeriod { get; set; }

        /// <summary>
        /// 生效周期模式
        /// </summary>
        [XmlElement("valid_type")]
        public string ValidType { get; set; }
    }
}

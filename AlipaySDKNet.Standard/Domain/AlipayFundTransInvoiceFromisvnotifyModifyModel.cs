using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransInvoiceFromisvnotifyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransInvoiceFromisvnotifyModifyModel : AopObject
    {
        /// <summary>
        /// 所属地区，用于区分不同地区票据应用
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 票据代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 票据号码
        /// </summary>
        [XmlElement("invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 默认0，是否是历史数据同步。历史数据不发蚂蚁森林能量 0 非历史数据 1 是历史数据
        /// </summary>
        [XmlElement("is_old_data_sync")]
        public string IsOldDataSync { get; set; }

        /// <summary>
        /// 当user_id不传值时payer_id_type必须传值，含义为用户身份标识类型 1 身份证
        /// </summary>
        [XmlElement("payer_id_type")]
        public string PayerIdType { get; set; }

        /// <summary>
        /// 当user_id为空时，payer_id_value必须传值，内容为与payer_id_type对应的标识值，如身份证号130xxx
        /// </summary>
        [XmlElement("payer_id_value")]
        public string PayerIdValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

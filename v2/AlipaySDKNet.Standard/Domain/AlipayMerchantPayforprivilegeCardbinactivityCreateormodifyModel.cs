using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 银行的标准缩写，大写。例如工行为ICBC、农行为ABC
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 规则中配置的银行卡卡bin。目前限制长度是6~8
        /// </summary>
        [XmlElement("card_bin")]
        public string CardBin { get; set; }

        /// <summary>
        /// 卡bin规则的外部活动唯一编号，联合对应商家的pid作为唯一键
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

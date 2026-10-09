using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPaysharingprodFamilypaySignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPaysharingprodFamilypaySignModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 亲情卡赠卡人信息
        /// </summary>
        [XmlElement("payer_info")]
        public FamilyPayBizUserInfo PayerInfo { get; set; }

        /// <summary>
        /// 签约额度信息
        /// </summary>
        [XmlElement("quota_info")]
        public FamilyPayQuotaInfo QuotaInfo { get; set; }

        /// <summary>
        /// 签约完成回跳地址
        /// </summary>
        [XmlElement("return_path")]
        public string ReturnPath { get; set; }

        /// <summary>
        /// 支付宝亲情卡业务定义给外部平台唯一业务身份标识，接入值咨询@子矛
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 收卡人信息
        /// </summary>
        [XmlElement("spender_info")]
        public FamilyPayBizUserInfo SpenderInfo { get; set; }
    }
}

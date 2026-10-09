using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPaysharingprodFamilypayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPaysharingprodFamilypayQueryModel : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 亲情卡卡号，如果需要查询指定亲情卡信息，需传入
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 支付宝亲情卡业务定义给外部平台唯一业务身份标识，接入前请咨询支付对接技术同学
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 当前用户信息
        /// </summary>
        [XmlElement("user_info")]
        public FamilyPayBizUserInfo UserInfo { get; set; }
    }
}

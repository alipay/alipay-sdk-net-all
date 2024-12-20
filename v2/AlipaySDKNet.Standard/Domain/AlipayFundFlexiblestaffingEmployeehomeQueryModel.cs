using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingEmployeehomeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingEmployeehomeQueryModel : AopObject
    {
        /// <summary>
        /// 协议号，与商户唯一订单号out_biz_no不能同时为空
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 商户端唯一订单号，与协议号agreement_no不能同时为空
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAuthorizeUniModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthorizeUniModifyModel : AopObject
    {
        /// <summary>
        /// 授权协议号，可从查询接口获取，与out_biz_no二选一传入即可
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授权跳转类型，有限枚举：SHORT_URL
        /// </summary>
        [XmlElement("authorize_link_type")]
        public string AuthorizeLinkType { get; set; }

        /// <summary>
        /// 业务场景码，固定值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳转渠道，优先枚举值: pc, h5, tinyapp
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 业务产品码，固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountbookPageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountbookPageCreateModel : AopObject
    {
        /// <summary>
        /// 账本别名
        /// </summary>
        [XmlElement("account_book_alias")]
        public string AccountBookAlias { get; set; }

        /// <summary>
        /// 业务场景码，固定值：代理页面创建
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务扩展字段
        /// </summary>
        [XmlElement("business_param")]
        public BusinessParamDTO BusinessParam { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签约开通商户主体信息
        /// </summary>
        [XmlElement("principal_info")]
        public PrincipalInfoDTO PrincipalInfo { get; set; }

        /// <summary>
        /// 产品码，固定值：资金账本管理
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}

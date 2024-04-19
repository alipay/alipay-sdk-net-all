using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSceneprodDiscountplanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodDiscountplanQueryModel : AopObject
    {
        /// <summary>
        /// 合作机构编码，由网商分配
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，与site有关，如site为MYBANK时这里需要填写网商会员号
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}

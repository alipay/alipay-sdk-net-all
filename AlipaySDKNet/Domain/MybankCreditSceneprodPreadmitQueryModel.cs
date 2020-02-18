using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSceneprodPreadmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodPreadmitQueryModel : AopObject
    {
        /// <summary>
        /// 客户姓名，开户时使用
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 机构特殊的校验规则
        /// </summary>
        [XmlElement("pre_admit_rule")]
        public string PreAdmitRule { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 本次请求流水号，全局唯一
        /// </summary>
        [XmlElement("seq_no")]
        public string SeqNo { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝； PERSON：身份证；
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，该字段内容与site的内容相关
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageCreateModel : AopObject
    {
        /// <summary>
        /// 统一社会信用代码。如果无法获取统一社会信用代码，也可以传递伙伴侧的企业标识，需要可以唯一标识一家企业
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 购买当前会员包的公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 订单编号，是指伙伴的正式向企信提交订单后，拿到的一个唯一的不重复订单号，届时伙伴的财务打款时需要附上该订单号，方便做资金流和订单的匹配
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 唯一键，幂等控制，同一个id不允许多次购买
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企信会员产品码，由企信分配
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 企信会员产品包定制化配置.仅对product_sku为QX-ZTB-ASSISTANT-STANDARD和QX-TK-ASSISTANT-STANDARD 是生效
        /// </summary>
        [XmlElement("product_config")]
        public EpAssistantProductConfig ProductConfig { get; set; }

        /// <summary>
        /// 企信会员产品包，由企信分配
        /// </summary>
        [XmlElement("product_sku")]
        public string ProductSku { get; set; }
    }
}

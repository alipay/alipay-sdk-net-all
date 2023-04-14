using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityDeliverychannelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityDeliverychannelQueryModel : AopObject
    {
        /// <summary>
        /// 当前服务商所代理的商户信息.  在查询可投放的渠道信息时，会使用商户信息来进行渠道权限、准入等条件的判断.  如果属于商户自运营，则该对象可以不填写。  如果属于服务商自运营，则对象中的businessType设置为ISV模式.默认使用当前操作人的信息作为商户信息  如果属于服务商代运营模式，则对象中的businessType设置为ISV_FOR_MERCHANT模式
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 展位码。  boothCode含义：boothCode表达的是某个渠道可以投放的展位码。例如：支付结果页PAY_RESULT  枚举值： PAY_RESULT：支付结果页。  后续新增可投放的展位后，会在文档中新增描述信息
        /// </summary>
        [XmlElement("booth_code")]
        public string BoothCode { get; set; }

        /// <summary>
        /// 查询的页码。  特别说明： 页码从1开始。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询的个数，最大值为 100。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}

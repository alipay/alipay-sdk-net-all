using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageDepositModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageDepositModel : AopObject
    {
        /// <summary>
        /// 充值的权益sku编码，一个sku可以包含不同权益项和权益数，假设本次权益包含3000次拓客解锁数，购买一个sku相当于购买了3000次拓客解锁数
        /// </summary>
        [XmlElement("benefit_sku_code")]
        public string BenefitSkuCode { get; set; }

        /// <summary>
        /// 购买的打包后的权益包的数量值
        /// </summary>
        [XmlElement("benefit_sku_quantity")]
        public long BenefitSkuQuantity { get; set; }

        /// <summary>
        /// 订单编号，是指伙伴的正式向企信提交订单后，拿到的一个唯一的不重复订单号，届时伙伴的财务同学打款时需要附上该订单号，方便做资金流和订单的匹配
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务ID,在调用本接口中需要保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 创建会员包返回的会员包编码
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}

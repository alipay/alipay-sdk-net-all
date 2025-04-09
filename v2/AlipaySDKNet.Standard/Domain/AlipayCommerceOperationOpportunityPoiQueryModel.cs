using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationOpportunityPoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationOpportunityPoiQueryModel : AopObject
    {
        /// <summary>
        /// 业务主体
        /// </summary>
        [XmlElement("biz_entity_info")]
        public BizEntityInfo BizEntityInfo { get; set; }

        /// <summary>
        /// 收银信息
        /// </summary>
        [XmlArray("cashier_info")]
        [XmlArrayItem("bs_cashier_info")]
        public List<BsCashierInfo> CashierInfo { get; set; }

        /// <summary>
        /// 证照信息
        /// </summary>
        [XmlElement("certificate_info")]
        public BsCertificateInfo CertificateInfo { get; set; }

        /// <summary>
        /// 定义联系人关联信息对象
        /// </summary>
        [XmlElement("contact_person_info")]
        public BsContactPersonInfo ContactPersonInfo { get; set; }

        /// <summary>
        /// 门店关联的支付宝类目
        /// </summary>
        [XmlElement("mcc_info")]
        public BsMccInfo MccInfo { get; set; }

        /// <summary>
        /// 外部业务流水号（业务申请编号；业务自定义，保证唯一）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 一笔支付宝交易单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 服务设备提报给支付宝的门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public BsShopInfoDetail ShopInfo { get; set; }
    }
}

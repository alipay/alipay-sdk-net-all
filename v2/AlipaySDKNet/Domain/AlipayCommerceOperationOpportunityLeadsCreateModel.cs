using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationOpportunityLeadsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationOpportunityLeadsCreateModel : AopObject
    {
        /// <summary>
        /// 业务主体
        /// </summary>
        [XmlElement("biz_entity_info")]
        public BizEntityInfo BizEntityInfo { get; set; }

        /// <summary>
        /// 收银机+小白盒收银：可铺设N5/N6 收银机+扫码枪：可铺设N5/N6 手持pos-不铺设：拦截 收款码-不铺设：拦截
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
        /// 自定义返佣金额
        /// </summary>
        [XmlElement("custom_pricing")]
        public long CustomPricing { get; set; }

        /// <summary>
        /// 设备数量
        /// </summary>
        [XmlElement("device_num")]
        public long DeviceNum { get; set; }

        /// <summary>
        /// 支付宝侧铺设设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 补充材料 ● 意愿确认单
        /// </summary>
        [XmlElement("extra_credentials")]
        public BsExtraCredentials ExtraCredentials { get; set; }

        /// <summary>
        /// leads线索来源
        /// </summary>
        [XmlElement("leads_from")]
        public string LeadsFrom { get; set; }

        /// <summary>
        /// 门店关联的支付宝类目
        /// </summary>
        [XmlElement("mcc_info")]
        public BsMccInfo MccInfo { get; set; }

        /// <summary>
        /// 商机ID
        /// </summary>
        [XmlElement("opportunity_id")]
        public string OpportunityId { get; set; }

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

        /// <summary>
        /// 饿了么渠道区分
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}

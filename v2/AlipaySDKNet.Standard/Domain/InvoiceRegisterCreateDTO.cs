using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceRegisterCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceRegisterCreateDTO : AopObject
    {
        /// <summary>
        /// 企业税务信息
        /// </summary>
        [XmlElement("invoice_company_dto")]
        public InvoiceCompanyDTO InvoiceCompanyDto { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlElement("invoice_contact_dto")]
        public InvoiceContactDTO InvoiceContactDto { get; set; }

        /// <summary>
        /// 服务市场订单信息
        /// </summary>
        [XmlArray("invoice_order_dto_list")]
        [XmlArrayItem("invoice_order_d_t_o")]
        public List<InvoiceOrderDTO> InvoiceOrderDtoList { get; set; }

        /// <summary>
        /// 外部业务幂等ID，由业务平台自己生成
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 业务平台code, 由发票中台分配
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台商户ID/用户ID
        /// </summary>
        [XmlElement("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 税控产品，产品码由中台定义
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 入驻类型，可选值：new：新订购，服务市场订购入驻场景，proxy：代理入驻模式，适用于代记账平台场景，online：已有税控初始化/绑定已有税控产品
        /// </summary>
        [XmlElement("register_type")]
        public string RegisterType { get; set; }
    }
}

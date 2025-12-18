using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiBuyerInvoiceInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiBuyerInvoiceInfoOrder : AopObject
    {
        /// <summary>
        /// 开票资料pid寻址方式, 默认true true:pid寻址mid,优先以mid维度保存开票资料,若无mid则以pid维度保存开票资料  false:不寻址mid,以pid维度保存开票资料
        /// </summary>
        [XmlElement("addressing")]
        public bool Addressing { get; set; }

        /// <summary>
        /// 自动开票设置, Y/N, 默认N
        /// </summary>
        [XmlElement("auto")]
        public string Auto { get; set; }

        /// <summary>
        /// 超开处置方式  ExceedInvoiceHandleEnum
        /// </summary>
        [XmlElement("exceed_invoice_handle_way")]
        public string ExceedInvoiceHandleWay { get; set; }

        /// <summary>
        /// 可选, 发票抬头, 为空不填写时，从CIF或MIF取值
        /// </summary>
        [XmlElement("invoice_title")]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 资格附件
        /// </summary>
        [XmlElement("qualification")]
        public string Qualification { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 公司注册电话
        /// </summary>
        [XmlElement("registered_phone_no")]
        public string RegisteredPhoneNo { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格开始时间，精确到天, 标准十分秒格式
        /// </summary>
        [XmlElement("taxpayer_start_date")]
        public string TaxpayerStartDate { get; set; }

        /// <summary>
        /// 可选, 纳税人类型, 传枚举TaxPayerQualificationEnum的englishName 不传的话默认一般纳税人GENERAL_VAT_TAXPAYER
        /// </summary>
        [XmlElement("taxpayer_type")]
        public string TaxpayerType { get; set; }

        /// <summary>
        /// 用户pid。用于保存购方资料, 不填则以虚拟pid 2088999999999999进行替代
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 邮寄信息集合
        /// </summary>
        [XmlArray("user_mail_info_orders")]
        [XmlArrayItem("open_api_user_mail_info_order")]
        public List<OpenApiUserMailInfoOrder> UserMailInfoOrders { get; set; }
    }
}

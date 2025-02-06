using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleQcReportProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleQcReportProductInfo : AopObject
    {
        /// <summary>
        /// 用户下单前的预估价格，单位为元，最多两位小数
        /// </summary>
        [XmlElement("estimated_price")]
        public string EstimatedPrice { get; set; }

        /// <summary>
        /// 产品编码，支付宝定义并在下单时回传给服务商
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 质检之后最终报价，单位为元，最多两位小数
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }
    }
}

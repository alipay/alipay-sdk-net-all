using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceOpenProductDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceOpenProductDTO : AopObject
    {
        /// <summary>
        /// 税控产品发票类型 可选值：电票：0，纸质普票：1，纸质专票：2
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 税控服务商，由服务商在中台入驻后生成
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 产品类型，产品码由中台定义
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 服务有效周期-结束时间
        /// </summary>
        [XmlElement("serv_end_time")]
        public string ServEndTime { get; set; }

        /// <summary>
        /// 服务有效周期-起始时间
        /// </summary>
        [XmlElement("serv_start_time")]
        public string ServStartTime { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayDeviceNlinkMerchantSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayDeviceNlinkMerchantSubmitModel : AopObject
    {
        /// <summary>
        /// 业务code
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 商户提交业务数据
        /// </summary>
        [XmlElement("merchant_content")]
        public MerchantContent MerchantContent { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 子业务code
        /// </summary>
        [XmlElement("sub_biz_code")]
        public string SubBizCode { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}

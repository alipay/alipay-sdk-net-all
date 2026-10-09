using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiFqqrcodeLogisticsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiFqqrcodeLogisticsQueryModel : AopObject
    {
        /// <summary>
        /// 扩展字段,用于一些定制化诉求.
        /// </summary>
        [XmlElement("fqqr_code_ext_info")]
        public FqQrCodeExtendParams FqqrCodeExtInfo { get; set; }

        /// <summary>
        /// 二级商户唯一标识
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 物料订单编号,调用申领接口时获取.
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 服务商唯一标识,联系支付宝工作人员获取.
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiFqqrcodeHbfqBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiFqqrcodeHbfqBindModel : AopObject
    {
        /// <summary>
        /// 扩展字段,用于满足一些定制化的绑定需求.
        /// </summary>
        [XmlElement("fqqr_code_ext_info")]
        public FqQrCodeExtendParams FqqrCodeExtInfo { get; set; }

        /// <summary>
        /// 外部请求号,用于唯一标识一次请求.仅可以由英文字母和数字组成.需要保证在服务商端不重复.
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 待绑定的二维码的码值.
        /// </summary>
        [XmlElement("qr_code_token")]
        public string QrCodeToken { get; set; }

        /// <summary>
        /// 二级商户唯一标识
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 服务商唯一标识,联系支付宝工作人员获取.
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 商店唯一标识,可以为空.
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}

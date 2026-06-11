using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectRefundSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectRefundSetModel : AopObject
    {
        /// <summary>
        /// 支付宝子商户号，一般是2088开头的数字，该子商户号由服务商进件而来。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 是否开启字段透传或关闭字段透传，如果未传则默认为开启。
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}

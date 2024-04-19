using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankQrcodedataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankQrcodedataQueryModel : AopObject
    {
        /// <summary>
        /// 查询的数据日期
        /// </summary>
        [XmlElement("data_date")]
        public string DataDate { get; set; }

        /// <summary>
        /// 二维码Id
        /// </summary>
        [XmlElement("qrcode_id")]
        public string QrcodeId { get; set; }

        /// <summary>
        /// 二维码外部ID
        /// </summary>
        [XmlElement("qrcode_out_id")]
        public string QrcodeOutId { get; set; }
    }
}

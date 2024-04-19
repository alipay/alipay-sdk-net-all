using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetCertInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetCertInfo : AopObject
    {
        /// <summary>
        /// 预付卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 预付卡卡密加密后的字符串
        /// </summary>
        [XmlElement("card_pwd")]
        public string CardPwd { get; set; }

        /// <summary>
        /// 预付卡卡模版Id
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 预付卡卡面额
        /// </summary>
        [XmlElement("denomination")]
        public string Denomination { get; set; }

        /// <summary>
        /// 制卡订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}

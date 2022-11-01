using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardAssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardAssetInfo : AopObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡密
        /// </summary>
        [XmlElement("card_pwd")]
        public string CardPwd { get; set; }
    }
}

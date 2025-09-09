using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdateCodeByIdSuccessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCodeByIdSuccessInfo : AopObject
    {
        /// <summary>
        /// 商品平台编码
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}

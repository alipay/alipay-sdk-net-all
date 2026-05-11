using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceCouponCreateResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceCouponCreateResponseDTO : AopObject
    {
        /// <summary>
        /// 海图费用减免记录id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 海图费用减免申请单号
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }
    }
}

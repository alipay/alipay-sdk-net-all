using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopcopydetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopcopydetailQueryModel : AopObject
    {
        /// <summary>
        /// 副本业务ID
        /// </summary>
        [XmlElement("copy_id")]
        public string CopyId { get; set; }

        /// <summary>
        /// 商户ID【查询非调用方门店详情必传】
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID【查询非调用方门店详情必传】
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}

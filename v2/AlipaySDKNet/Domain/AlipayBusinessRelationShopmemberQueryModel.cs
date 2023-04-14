using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopmemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationShopmemberQueryModel : AopObject
    {
        /// <summary>
        /// 商业组织关系中商圈的ownerPid
        /// </summary>
        [XmlElement("mall_pid")]
        public string MallPid { get; set; }

        /// <summary>
        /// 圈店时填写的门店编号
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }
    }
}

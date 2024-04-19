using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppGongyiTestQueryResponse.
    /// </summary>
    public class AlipayOpenAppGongyiTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("createdate")]
        public string Createdate { get; set; }

        /// <summary>
        /// 测试测试测试测试测试
        /// </summary>
        [XmlElement("shopaddress")]
        public AlipayGongyiAddressTest Shopaddress { get; set; }

        /// <summary>
        /// 商铺信息
        /// </summary>
        [XmlElement("shopinfo")]
        public OuterShopDO Shopinfo { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shopname")]
        public string Shopname { get; set; }

        /// <summary>
        /// 测试测试测试
        /// </summary>
        [XmlElement("shoprecord")]
        public AlipayGongyiModelTest Shoprecord { get; set; }
    }
}

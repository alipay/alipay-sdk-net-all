using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayGongyiModelTest Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayGongyiModelTest : AopObject
    {
        /// <summary>
        /// zhangsan
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// buyer@163.com
        /// </summary>
        [XmlElement("buyer_email")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// 10.12
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// asdf
        /// </summary>
        [XmlElement("seller")]
        public string Seller { get; set; }

        /// <summary>
        /// seller@email.com
        /// </summary>
        [XmlElement("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// userfino
        /// </summary>
        [XmlElement("userinfo")]
        public AlipayGongyiUserInfoTest Userinfo { get; set; }
    }
}

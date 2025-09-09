using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderSubmitResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyOrderSubmitResponse : AopResponse
    {
        /// <summary>
        /// 该申请单下的物料总数
        /// </summary>
        [XmlElement("materials_num")]
        public long MaterialsNum { get; set; }

        /// <summary>
        /// 申请单下的门店数量
        /// </summary>
        [XmlElement("shop_num")]
        public long ShopNum { get; set; }
    }
}

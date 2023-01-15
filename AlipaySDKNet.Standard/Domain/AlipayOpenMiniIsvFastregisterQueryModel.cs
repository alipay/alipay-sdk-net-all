using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvFastregisterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIsvFastregisterQueryModel : AopObject
    {
        /// <summary>
        /// 代创建试用小程序单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
